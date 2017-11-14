using System;
using Digiseller.Client.Core.Enums;
using Digiseller.Client.Core.Interfaces.ProductInformation;
using Digiseller.Client.Core.Models.ProductInformation.Response;

namespace Digiseller.Client.Core.ViewModels.ProductInformation
{
    public class ProductVideo : IProductVideo
    {
        public VideoType Type { get; }
        public string Id { get; }
        public string UrlImagePreview { get; }

        public ProductVideo(PreviewVideo video)
        {
            Id = video.Id;
            UrlImagePreview = video.Preview;
            Type = Enum.TryParse(video.Type, out VideoType type) ? type : VideoType.Unknown;
        }
    }
}