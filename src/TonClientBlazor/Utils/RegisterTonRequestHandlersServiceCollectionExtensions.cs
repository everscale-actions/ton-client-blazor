using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using ch1seL.TonClientBlazor.Abstract;
using ch1seL.TonClientBlazor.Mediator;
using ch1seL.TonClientBlazor.Mediator.Abstract;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ch1seL.TonClientBlazor.Utils
{
    internal static class RegisterTonRequestHandlersServiceCollectionExtensions
    {
        public static IServiceCollection RegisterTonRequestHandlers(this IServiceCollection serviceCollection)
        {
            RegisterMainRequestHandlers(serviceCollection);

            RegisterByTonClientResponseTypes(serviceCollection);

            RegisterByTonGraphQlResponseTypes(serviceCollection);

            return serviceCollection;
        }

        private static void RegisterByTonGraphQlResponseTypes(IServiceCollection serviceCollection)
        {
            Type responseTypeInterface = typeof(ITonGraphQLResponseType);
            var responseResultTypes = responseTypeInterface.Assembly.GetTypes()
                .Where(t => responseTypeInterface.IsAssignableFrom(t) && !t.IsInterface);
            foreach (Type responseType in responseResultTypes)
            {
                Type responseCollectionType = typeof(IReadOnlyList<>).MakeGenericType(responseType);
                Type requestType = typeof(GetByParametersRequest<>).MakeGenericType(responseCollectionType);
                serviceCollection.TryAddTransient(typeof(IRequestHandler<,>).MakeGenericType(requestType, responseCollectionType),
                    typeof(TonClientCommonRequestHandler<,>).MakeGenericType(requestType, responseCollectionType));
            }
        }

        private static void RegisterByTonClientResponseTypes(IServiceCollection serviceCollection)
        {
            var responseResultPrimitiveTypes = new[]
            {
                typeof(object),
                typeof(JsonDocument),
                typeof(TimeSpan),
                typeof(DateTime),
                typeof(string),
                typeof(bool),
                typeof(object[])
            };

            Type responseTypeInterface = typeof(ITonClientResponseType);
            var responseResultTypes = responseTypeInterface.Assembly.GetTypes()
                .Where(t => responseTypeInterface.IsAssignableFrom(t) && !t.IsInterface)
                .Union(responseResultPrimitiveTypes);
            foreach (Type responseType in responseResultTypes)
            {
                Type requestType = typeof(GetByParametersRequest<>).MakeGenericType(responseType);
                serviceCollection.TryAddTransient(typeof(IRequestHandler<,>).MakeGenericType(requestType, responseType),
                    typeof(TonClientCommonRequestHandler<,>).MakeGenericType(requestType, responseType));
            }
        }

        private static void RegisterMainRequestHandlers(IServiceCollection serviceCollection)
        {
            Type tonClientRequestType = typeof(ITonClientRequest<>);
            var requestTypes = tonClientRequestType.Assembly.GetTypes()
                .Where(t => !t.IsGenericTypeDefinition && IsAssignableToGenericType(t, tonClientRequestType) && !t.IsInterface).ToArray();
            foreach (Type requestType in requestTypes)
            {
                Type responseType = requestType.GetInterface("ITonClientRequest`1")!.GetGenericArguments()[0];
                serviceCollection.TryAddTransient(typeof(IRequestHandler<,>).MakeGenericType(requestType, responseType),
                    typeof(TonClientCommonRequestHandler<,>).MakeGenericType(requestType, responseType));
            }
        }

        private static bool IsAssignableToGenericType(Type givenType, Type genericType)
        {
            var interfaceTypes = givenType.GetInterfaces();

            if (interfaceTypes.Any(it => it.IsGenericType && it.GetGenericTypeDefinition() == genericType)) return true;

            if (givenType.IsGenericType && givenType.GetGenericTypeDefinition() == genericType)
                return true;

            Type baseType = givenType.BaseType;
            return baseType != null && IsAssignableToGenericType(baseType, genericType);
        }
    }
}