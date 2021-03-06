﻿using System.ComponentModel.DataAnnotations;
using VirtoCommerce.Platform.Core.Common;

namespace VirtoCommerce.ContentModule.Data.Models
{
    public class MenuLink : AuditableEntity
    {
        [Required]
        [StringLength(1024)]
        public string Title { get; set; }
        [Required]
        [StringLength(2048)]
        public string Url { get; set; }
        [Required]
        public int Priority { get; set; }
        [StringLength(254)]
        public string AssociatedObjectType { get; set; }
        [StringLength(254)]
        public string AssociatedObjectName { get; set; }
        [StringLength(128)]
        public string AssociatedObjectId { get; set; }
        public virtual MenuLinkList MenuLinkList { get; set; }
        public string MenuLinkListId { get; set; }
    }
}
