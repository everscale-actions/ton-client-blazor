using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor;
using ch1seL.TonClientBlazor.Mediator;
using ch1seL.TonClientBlazor.Modules.Contract;
using MediatR;

namespace ch1seL.TonClientModules
{
    internal class TonContractsModule : ITonContractsModule
    {
        private readonly IMediator _mediator;

        public TonContractsModule(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<TonContractLoadResult> Load(TonContractLoadParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractLoadResult>(TonClientMethods.Contract.Load, @params), cancellationToken);
        }

        public async Task<TonContractDeployResult> Deploy(TonContractDeployParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractDeployResult>(TonClientMethods.Contract.Deploy, @params), cancellationToken);
        }

        public async Task<TonContractRunResult> Run(TonContractRunParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractRunResult>(TonClientMethods.Contract.Run, @params), cancellationToken);
        }

        public async Task<TonContractRunLocalResult> RunLocal(TonContractRunLocalParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractRunLocalResult>(TonClientMethods.Contract.RunLocal, @params), cancellationToken);
        }

        public async Task<TonContractRunLocalResult> RunMessageLocal(TonContractRunMessageLocalParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractRunLocalResult>(TonClientMethods.Contract.RunMessageLocal, @params),
                cancellationToken);
        }

        public async Task<TonContractRunGetResult> RunGet(TonContractRunGetParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractRunGetResult>(TonClientMethods.Contract.RunGet, @params), cancellationToken);
        }

        public async Task<object[]> ArrayFromCons(object[] cons, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<object[]>(TonClientMethods.Contract.ArrayFromCons, cons), cancellationToken);
        }

        public async Task<TonContractDeployMessage> CreateDeployMessage(TonContractDeployParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractDeployMessage>(TonClientMethods.Contract.CreateDeployMessage, @params),
                cancellationToken);
        }

        public async Task<TonContractRunGetResult> CreateRunMessage(TonContractRunParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractRunGetResult>(TonClientMethods.Contract.CreateRunMessage, @params),
                cancellationToken);
        }

        public async Task<TonContractUnsignedDeployMessage> CreateUnsignedDeployMessage(TonContractDeployParams @params,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(
                new GetByParametersRequest<TonContractUnsignedDeployMessage>(TonClientMethods.Contract.CreateUnsignedDeployMessage, @params),
                cancellationToken);
        }

        public async Task<TonContractUnsignedRunMessage> CreateUnsignedRunMessage(TonContractRunParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractUnsignedRunMessage>(TonClientMethods.Contract.CreateUnsignedRunMessage, @params),
                cancellationToken);
        }

        public async Task<TonMessage> CreateSignedMessage(TonContractCreateSignedMessageParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonMessage>(TonClientMethods.Contract.CreateSignedMessage, @params), cancellationToken);
        }

        public async Task<TonContractDeployMessage> CreateSignedDeployMessage(TonContractCreateSignedDeployMessageParams @params,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractDeployMessage>(TonClientMethods.Contract.CreateSignedDeployMessage, @params),
                cancellationToken);
        }

        public async Task<TonContractRunMessage> CreateSignedRunMessage(TonContractCreateSignedRunMessageParams @params,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractRunMessage>(TonClientMethods.Contract.CreateSignedRunMessage, @params),
                cancellationToken);
        }

        public async Task<TonContractGetCodeFromImageResult> GetCodeFromImage(TonContractGetCodeFromImageParams @params,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractGetCodeFromImageResult>(TonClientMethods.Contract.GetCodeFromImage, @params),
                cancellationToken);
        }

        public async Task<TonContractGetDeployDataResult> GetDeployData(TonContractGetDeployDataParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractGetDeployDataResult>(TonClientMethods.Contract.GetDeployData, @params),
                cancellationToken);
        }

        public async Task<TonContractCreateRunBodyResult> CreateRunBody(TonContractCreateRunBodyParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractCreateRunBodyResult>(TonClientMethods.Contract.CreateRunBody, @params),
                cancellationToken);
        }

        public async Task<TonContractGetFunctionIdResult> GetFunctionId(TonContractGetFunctionIdParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractGetFunctionIdResult>(TonClientMethods.Contract.GetFunctionId, @params),
                cancellationToken);
        }

        public async Task<TonMessage> ParseMessage(TonContractBoc @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonMessage>(TonClientMethods.Contract.ParseMessage, @params), cancellationToken);
        }

        public async Task<TonContractRunResult> DecodeRunOutput(TonContractDecodeRunOutputParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractRunResult>(TonClientMethods.Contract.DecodeRunOutput, @params),
                cancellationToken);
        }

        public async Task<TonContractDecodeMessageBodyResult> DecodeInputMessageBody(TonContractDecodeMessageBodyParams @params,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(
                new GetByParametersRequest<TonContractDecodeMessageBodyResult>(TonClientMethods.Contract.DecodeInputMessageBody, @params), cancellationToken);
        }

        public async Task<TonContractDecodeMessageBodyResult> DecodeOutputMessageBody(TonContractDecodeMessageBodyParams @params,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(
                new GetByParametersRequest<TonContractDecodeMessageBodyResult>(TonClientMethods.Contract.DecodeOutputMessageBody, @params), cancellationToken);
        }

        public async Task<string> EnsureMessageId(TonMessage @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Contract.EnsureMessageId, @params), cancellationToken);
        }

        public async Task<TonMessageProcessingState> SendMessage(TonMessage @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonMessageProcessingState>(TonClientMethods.Contract.SendMessage, @params),
                cancellationToken);
        }

        public async Task<TonContractRunResult> WaitForTransaction(TonWaitForTransactionParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractRunResult>(TonClientMethods.Contract.WaitForTransaction, @params),
                cancellationToken);
        }

        public async Task<TonContractDeployResult> WaitForDeployTransaction(TonContractDeployMessage deployMessage,
            TonMessageProcessingState messageProcessingState, bool? infiniteWait = null,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(
                new GetByParametersRequest<TonContractDeployResult>(TonClientMethods.Contract.WaitForDeployTransaction, deployMessage, messageProcessingState,
                    infiniteWait), cancellationToken);
        }

        public async Task<TonContractRunResult> WaitForRunTransaction(TonContractRunMessage deployMessage, TonMessageProcessingState messageProcessingState,
            bool infiniteWait,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(
                new GetByParametersRequest<TonContractRunResult>(TonClientMethods.Contract.WaitForRunTransaction, deployMessage, messageProcessingState,
                    infiniteWait), cancellationToken);
        }

        public async Task<string> ProcessMessage(TonMessage message, TonAbi abi = null, string functionName = null,
            CancellationToken cancellationToken = default)
        {
            var @params = new object[]
            {
                message,
                null, // unused resultFields
                null, // parentSpan nothing to pass yet
                null, // unused retryIndex
                null, // unused address,
                abi,
                functionName
            };

            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Contract.ProcessMessage, @params), cancellationToken);
        }

        public async Task<TonContractDeployResult> ProcessDeployMessage(TonContractDeployMessage @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractDeployResult>(TonClientMethods.Contract.ProcessDeployMessage, @params),
                cancellationToken);
        }

        public async Task<TonContractRunResult> ProcessRunMessage(TonContractRunMessage @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractRunResult>(TonClientMethods.Contract.ProcessRunMessage, @params),
                cancellationToken);
        }

        public async Task<TonContractCalcFeeResult> CalcRunFees(TonContractCalcRunFeeParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractCalcFeeResult>(TonClientMethods.Contract.CalcRunFees, @params),
                cancellationToken);
        }

        public async Task<TonContractCalcFeeResult> CalcDeployFees(TonContractCalcDeployFeeParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractCalcFeeResult>(TonClientMethods.Contract.CalcDeployFees, @params),
                cancellationToken);
        }

        public async Task<TonContractCalcFeeResult> CalcMsgProcessFees(TonContractCalcMsgProcessingFeesParams @params,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractCalcFeeResult>(TonClientMethods.Contract.CalcMsgProcessFees, @params),
                cancellationToken);
        }

        public async Task<TonContractConvertAddressResult> ConvertAddress(TonContractConvertAddressParams @params,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonContractConvertAddressResult>(TonClientMethods.Contract.ConvertAddress, @params),
                cancellationToken);
        }

        public async Task<TonAccount> GetAccount(string address, bool active, TonWaitParams waitParams, CancellationToken cancellationToken = default)
        {
            var @params = new object[] {address, active, waitParams};
            return await _mediator.Send(new GetByParametersRequest<TonAccount>(TonClientMethods.Contract.GetAccount, @params), cancellationToken);
        }
    }
}