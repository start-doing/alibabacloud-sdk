// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateMeshFeatureRequest : TeaModel {
        [NameInMap("ServiceMeshId")]
        [Validation(Required=true)]
        public string ServiceMeshId { get; set; }

        [NameInMap("Tracing")]
        [Validation(Required=false)]
        public bool? Tracing { get; set; }

        [NameInMap("TraceSampling")]
        [Validation(Required=false)]
        public float? TraceSampling { get; set; }

        [NameInMap("LocalityLoadBalancing")]
        [Validation(Required=false)]
        public bool? LocalityLoadBalancing { get; set; }

        [NameInMap("Telemetry")]
        [Validation(Required=false)]
        public bool? Telemetry { get; set; }

        [NameInMap("OpenAgentPolicy")]
        [Validation(Required=false)]
        public bool? OpenAgentPolicy { get; set; }

        [NameInMap("OPALogLevel")]
        [Validation(Required=false)]
        public string OPALogLevel { get; set; }

        [NameInMap("OPARequestCPU")]
        [Validation(Required=false)]
        public string OPARequestCPU { get; set; }

        [NameInMap("OPARequestMemory")]
        [Validation(Required=false)]
        public string OPARequestMemory { get; set; }

        [NameInMap("OPALimitCPU")]
        [Validation(Required=false)]
        public string OPALimitCPU { get; set; }

        [NameInMap("OPALimitMemory")]
        [Validation(Required=false)]
        public string OPALimitMemory { get; set; }

        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        [NameInMap("ClusterDomain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

    }

}
