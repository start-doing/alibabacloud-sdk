// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteAutoProvisioningGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("AutoProvisioningGroupId")]
        [Validation(Required=true)]
        public string AutoProvisioningGroupId { get; set; }

        [NameInMap("TerminateInstances")]
        [Validation(Required=true)]
        public bool? TerminateInstances { get; set; }

    }

}