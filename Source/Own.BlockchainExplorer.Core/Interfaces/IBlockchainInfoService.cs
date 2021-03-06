using Own.BlockchainExplorer.Common.Framework;
using Own.BlockchainExplorer.Core.Dtos.Api;
using System.Collections.Generic;

namespace Own.BlockchainExplorer.Core.Interfaces
{
    public interface IBlockchainInfoService
    {
        Result<EquivocationInfoDto> GetEquivocationInfo(string EquivocationProofHash);
        Result<AccountInfoDto> GetAccountInfo(string accountHash);
        Result<AssetInfoDto> GetAssetInfo(string assetHash);
        Result<ValidatorInfoDto> GetValidatorInfo(string blockchainAddress);

        Result<IEnumerable<TxInfoShortDto>> GetTxs(int limit, int page);
        Result<IEnumerable<BlockInfoShortDto>> GetBlocks(int limit, int page);
        Result<IEnumerable<ValidatorInfoShortDto>> GetValidators();

        Result<object> Search(string hash);
    }
}
