// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ImportSnapshotResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public string TaskId { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=true)]
        public string SnapshotId { get; set; }

    }

}
