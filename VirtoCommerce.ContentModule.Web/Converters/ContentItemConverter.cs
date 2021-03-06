﻿using Omu.ValueInjecter;
using System;
using VirtoCommerce.ContentModule.Web.Models;
using VirtoCommerce.Platform.Core.Assets;
using VirtoCommerce.Platform.Core.Common;

namespace VirtoCommerce.ContentModule.Web.Converters
{
    public static class ContentItemConverter
    {
        public static ContentFolder ToContentModel(this BlobFolder blobFolder)
        {
            var retVal = new ContentFolder();
            retVal.InjectFrom(blobFolder);
            return retVal;
        }

        public static BlobFolder ToBlobModel(this ContentFolder folder)
        {
            var retVal = new BlobFolder();
            retVal.InjectFrom(folder);
            return retVal;
        }

        public static ContentFile ToContentModel(this BlobInfo blobInfo)
        {
			if (blobInfo == null)
				throw new ArgumentNullException(nameof(blobInfo));

			var retVal = new ContentFile();
            retVal.InjectFrom(blobInfo);
            retVal.Name = blobInfo.FileName;
            retVal.MimeType = blobInfo.ContentType;
            retVal.Size = blobInfo.Size.ToString();
            retVal.ModifiedDate = blobInfo.ModifiedDate;
            return retVal;
        }

        public static BlobInfo ToBlobModel(this ContentFile file)
        {
            var retVal = new BlobInfo();
            retVal.InjectFrom(file);
            return retVal;
        }
    }
}
