// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeRegionsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=true)]
        public DescribeRegionsResponseRegions Regions { get; set; }
        public class DescribeRegionsResponseRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=true)]
            public List<DescribeRegionsResponseRegionsRegion> Region { get; set; }
            public class DescribeRegionsResponseRegionsRegion : TeaModel {
                    public string RegionId { get; set; }
                    public string LocalName { get; set; }
                    public string RegionEndpoint { get; set; }
            }
        };

    }

}
