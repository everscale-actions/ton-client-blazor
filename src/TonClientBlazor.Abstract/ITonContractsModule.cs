using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor.Modules.Contract;

namespace ch1seL.TonClientBlazor
{
    public interface ITonContractsModule
    {
        Task<TonContractLoadResult> Load(TonContractLoadParams @params, CancellationToken cancellationToken = default);
        Task<TonContractDeployResult> Deploy(TonContractDeployParams @params, CancellationToken cancellationToken = default);
        Task<TonContractRunResult> Run(TonContractRunParams @params, CancellationToken cancellationToken = default);
        Task<TonContractRunLocalResult> RunLocal(TonContractRunLocalParams @params, CancellationToken cancellationToken = default);
        Task<TonContractRunLocalResult> RunMessageLocal(TonContractRunMessageLocalParams @params, CancellationToken cancellationToken = default);
        Task<TonContractRunGetResult> RunGet(TonContractRunGetParams @params, CancellationToken cancellationToken = default);
        Task<object[]> ArrayFromCons(object[] cons, CancellationToken cancellationToken = default);
        Task<TonContractDeployMessage> CreateDeployMessage(TonContractDeployParams @params, CancellationToken cancellationToken = default);
        Task<TonContractRunGetResult> CreateRunMessage(TonContractRunParams @params, CancellationToken cancellationToken = default);
        Task<TonContractUnsignedDeployMessage> CreateUnsignedDeployMessage(TonContractDeployParams @params, CancellationToken cancellationToken = default);
        Task<TonContractUnsignedRunMessage> CreateUnsignedRunMessage(TonContractRunParams @params, CancellationToken cancellationToken = default);
        Task<TonMessage> CreateSignedMessage(TonContractCreateSignedMessageParams @params, CancellationToken cancellationToken = default);

        Task<TonContractDeployMessage> CreateSignedDeployMessage(TonContractCreateSignedDeployMessageParams @params,
            CancellationToken cancellationToken = default);

        Task<TonContractRunMessage> CreateSignedRunMessage(TonContractCreateSignedRunMessageParams @params, CancellationToken cancellationToken = default);
        Task<TonContractGetCodeFromImageResult> GetCodeFromImage(TonContractGetCodeFromImageParams @params, CancellationToken cancellationToken = default);
        Task<TonContractGetDeployDataResult> GetDeployData(TonContractGetDeployDataParams @params, CancellationToken cancellationToken = default);
        Task<TonContractCreateRunBodyResult> CreateRunBody(TonContractCreateRunBodyParams @params, CancellationToken cancellationToken = default);
        Task<TonContractGetFunctionIdResult> GetFunctionId(TonContractGetFunctionIdParams @params, CancellationToken cancellationToken = default);
        Task<TonMessage> ParseMessage(TonContractBoc @params, CancellationToken cancellationToken = default);
        Task<TonContractRunResult> DecodeRunOutput(TonContractDecodeRunOutputParams @params, CancellationToken cancellationToken = default);

        Task<TonContractDecodeMessageBodyResult> DecodeInputMessageBody(TonContractDecodeMessageBodyParams @params,
            CancellationToken cancellationToken = default);

        Task<TonContractDecodeMessageBodyResult> DecodeOutputMessageBody(TonContractDecodeMessageBodyParams @params,
            CancellationToken cancellationToken = default);

        Task<string> EnsureMessageId(TonMessage @params, CancellationToken cancellationToken = default);
        Task<TonMessageProcessingState> SendMessage(TonMessage @params, CancellationToken cancellationToken = default);
        Task<TonContractRunResult> WaitForTransaction(TonWaitForTransactionParams @params, CancellationToken cancellationToken = default);

        Task<TonContractDeployResult> WaitForDeployTransaction(TonContractDeployMessage deployMessage, TonMessageProcessingState messageProcessingState,
            bool? infiniteWait = null, CancellationToken cancellationToken = default);

        Task<TonContractRunResult> WaitForRunTransaction(TonContractRunMessage deployMessage, TonMessageProcessingState messageProcessingState,
            bool infiniteWait, CancellationToken cancellationToken = default);

        Task<string> ProcessMessage(TonMessage message, TonAbi abi = null, string functionName = null, CancellationToken cancellationToken = default);
        Task<TonContractDeployResult> ProcessDeployMessage(TonContractDeployMessage @params, CancellationToken cancellationToken = default);
        Task<TonContractRunResult> ProcessRunMessage(TonContractRunMessage @params, CancellationToken cancellationToken = default);
        Task<TonContractCalcFeeResult> CalcRunFees(TonContractCalcRunFeeParams @params, CancellationToken cancellationToken = default);
        Task<TonContractCalcFeeResult> CalcDeployFees(TonContractCalcDeployFeeParams @params, CancellationToken cancellationToken = default);
        Task<TonContractCalcFeeResult> CalcMsgProcessFees(TonContractCalcMsgProcessingFeesParams @params, CancellationToken cancellationToken = default);
        Task<TonContractConvertAddressResult> ConvertAddress(TonContractConvertAddressParams @params, CancellationToken cancellationToken = default);
        Task<TonAccount> GetAccount(string address, bool active, TonWaitParams waitParams, CancellationToken cancellationToken = default);
    }
}