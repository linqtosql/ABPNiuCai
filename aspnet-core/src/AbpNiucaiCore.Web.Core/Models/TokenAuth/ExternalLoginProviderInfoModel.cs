using Abp.AutoMapper;
using AbpNiucaiCore.Authentication.External;

namespace AbpNiucaiCore.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
