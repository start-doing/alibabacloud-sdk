// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class ChangeVideoSizeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ChangeVideoSizeResponseData Data { get; set; }
        public class ChangeVideoSizeResponseData : TeaModel {
            [NameInMap("VideoUrl")]
            [Validation(Required=true)]
            public string VideoUrl { get; set; }
            [NameInMap("VideoCoverUrl")]
            [Validation(Required=true)]
            public string VideoCoverUrl { get; set; }
        };

    }

}
