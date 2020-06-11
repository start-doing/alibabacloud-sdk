// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeRelatedResourcesReuseResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ReuseInfo")]
        [Validation(Required=true)]
        public List<Dictionary<string, object>> ReuseInfo { get; set; }

    }

}
