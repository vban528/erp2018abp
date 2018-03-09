﻿using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;

namespace erp2018abp.Roles.Dto
{
    [AutoMapFrom(typeof(Permission))]
    public class PermissionDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }
    }
}