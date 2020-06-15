// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Servicemesh20200111.Models;

namespace AlibabaCloud.SDK.Servicemesh20200111
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("servicemesh", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public RemoveClusterFromServiceMeshResponse RemoveClusterFromServiceMeshWithOptions(RemoveClusterFromServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveClusterFromServiceMeshResponse>(DoRequest("RemoveClusterFromServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RemoveClusterFromServiceMeshResponse> RemoveClusterFromServiceMeshWithOptionsAsync(RemoveClusterFromServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveClusterFromServiceMeshResponse>(await DoRequestAsync("RemoveClusterFromServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public RemoveClusterFromServiceMeshResponse RemoveClusterFromServiceMesh(RemoveClusterFromServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveClusterFromServiceMeshWithOptions(request, runtime);
        }

        public async Task<RemoveClusterFromServiceMeshResponse> RemoveClusterFromServiceMeshAsync(RemoveClusterFromServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveClusterFromServiceMeshWithOptionsAsync(request, runtime);
        }

        public AddClusterIntoServiceMeshResponse AddClusterIntoServiceMeshWithOptions(AddClusterIntoServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddClusterIntoServiceMeshResponse>(DoRequest("AddClusterIntoServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddClusterIntoServiceMeshResponse> AddClusterIntoServiceMeshWithOptionsAsync(AddClusterIntoServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddClusterIntoServiceMeshResponse>(await DoRequestAsync("AddClusterIntoServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public AddClusterIntoServiceMeshResponse AddClusterIntoServiceMesh(AddClusterIntoServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddClusterIntoServiceMeshWithOptions(request, runtime);
        }

        public async Task<AddClusterIntoServiceMeshResponse> AddClusterIntoServiceMeshAsync(AddClusterIntoServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddClusterIntoServiceMeshWithOptionsAsync(request, runtime);
        }

        public UpdateIstioInjectionConfigResponse UpdateIstioInjectionConfigWithOptions(UpdateIstioInjectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateIstioInjectionConfigResponse>(DoRequest("UpdateIstioInjectionConfig", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateIstioInjectionConfigResponse> UpdateIstioInjectionConfigWithOptionsAsync(UpdateIstioInjectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateIstioInjectionConfigResponse>(await DoRequestAsync("UpdateIstioInjectionConfig", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public UpdateIstioInjectionConfigResponse UpdateIstioInjectionConfig(UpdateIstioInjectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIstioInjectionConfigWithOptions(request, runtime);
        }

        public async Task<UpdateIstioInjectionConfigResponse> UpdateIstioInjectionConfigAsync(UpdateIstioInjectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIstioInjectionConfigWithOptionsAsync(request, runtime);
        }

        public DescribeGuestClusterAccessLogDashboardsResponse DescribeGuestClusterAccessLogDashboardsWithOptions(DescribeGuestClusterAccessLogDashboardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeGuestClusterAccessLogDashboardsResponse>(DoRequest("DescribeGuestClusterAccessLogDashboards", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeGuestClusterAccessLogDashboardsResponse> DescribeGuestClusterAccessLogDashboardsWithOptionsAsync(DescribeGuestClusterAccessLogDashboardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeGuestClusterAccessLogDashboardsResponse>(await DoRequestAsync("DescribeGuestClusterAccessLogDashboards", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeGuestClusterAccessLogDashboardsResponse DescribeGuestClusterAccessLogDashboards(DescribeGuestClusterAccessLogDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGuestClusterAccessLogDashboardsWithOptions(request, runtime);
        }

        public async Task<DescribeGuestClusterAccessLogDashboardsResponse> DescribeGuestClusterAccessLogDashboardsAsync(DescribeGuestClusterAccessLogDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGuestClusterAccessLogDashboardsWithOptionsAsync(request, runtime);
        }

        public DescribeReusableSlbResponse DescribeReusableSlbWithOptions(DescribeReusableSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeReusableSlbResponse>(DoRequest("DescribeReusableSlb", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeReusableSlbResponse> DescribeReusableSlbWithOptionsAsync(DescribeReusableSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeReusableSlbResponse>(await DoRequestAsync("DescribeReusableSlb", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeReusableSlbResponse DescribeReusableSlb(DescribeReusableSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReusableSlbWithOptions(request, runtime);
        }

        public async Task<DescribeReusableSlbResponse> DescribeReusableSlbAsync(DescribeReusableSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReusableSlbWithOptionsAsync(request, runtime);
        }

        public DescribeClusterPrometheusResponse DescribeClusterPrometheusWithOptions(DescribeClusterPrometheusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterPrometheusResponse>(DoRequest("DescribeClusterPrometheus", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeClusterPrometheusResponse> DescribeClusterPrometheusWithOptionsAsync(DescribeClusterPrometheusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterPrometheusResponse>(await DoRequestAsync("DescribeClusterPrometheus", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeClusterPrometheusResponse DescribeClusterPrometheus(DescribeClusterPrometheusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterPrometheusWithOptions(request, runtime);
        }

        public async Task<DescribeClusterPrometheusResponse> DescribeClusterPrometheusAsync(DescribeClusterPrometheusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterPrometheusWithOptionsAsync(request, runtime);
        }

        public DescribeClusterGrafanaResponse DescribeClusterGrafanaWithOptions(DescribeClusterGrafanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterGrafanaResponse>(DoRequest("DescribeClusterGrafana", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeClusterGrafanaResponse> DescribeClusterGrafanaWithOptionsAsync(DescribeClusterGrafanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterGrafanaResponse>(await DoRequestAsync("DescribeClusterGrafana", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeClusterGrafanaResponse DescribeClusterGrafana(DescribeClusterGrafanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterGrafanaWithOptions(request, runtime);
        }

        public async Task<DescribeClusterGrafanaResponse> DescribeClusterGrafanaAsync(DescribeClusterGrafanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterGrafanaWithOptionsAsync(request, runtime);
        }

        public DescribeRelatedResourcesReuseResponse DescribeRelatedResourcesReuseWithOptions(DescribeRelatedResourcesReuseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRelatedResourcesReuseResponse>(DoRequest("DescribeRelatedResourcesReuse", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRelatedResourcesReuseResponse> DescribeRelatedResourcesReuseWithOptionsAsync(DescribeRelatedResourcesReuseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRelatedResourcesReuseResponse>(await DoRequestAsync("DescribeRelatedResourcesReuse", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeRelatedResourcesReuseResponse DescribeRelatedResourcesReuse(DescribeRelatedResourcesReuseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRelatedResourcesReuseWithOptions(request, runtime);
        }

        public async Task<DescribeRelatedResourcesReuseResponse> DescribeRelatedResourcesReuseAsync(DescribeRelatedResourcesReuseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRelatedResourcesReuseWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRequest("DescribeRegions", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRequestAsync("DescribeRegions", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeCensResponse DescribeCensWithOptions(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCensResponse>(DoRequest("DescribeCens", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCensResponse> DescribeCensWithOptionsAsync(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCensResponse>(await DoRequestAsync("DescribeCens", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeCensResponse DescribeCens(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCensWithOptions(request, runtime);
        }

        public async Task<DescribeCensResponse> DescribeCensAsync(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCensWithOptionsAsync(request, runtime);
        }

        public DescribeClustersInServiceMeshResponse DescribeClustersInServiceMeshWithOptions(DescribeClustersInServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClustersInServiceMeshResponse>(DoRequest("DescribeClustersInServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeClustersInServiceMeshResponse> DescribeClustersInServiceMeshWithOptionsAsync(DescribeClustersInServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClustersInServiceMeshResponse>(await DoRequestAsync("DescribeClustersInServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeClustersInServiceMeshResponse DescribeClustersInServiceMesh(DescribeClustersInServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClustersInServiceMeshWithOptions(request, runtime);
        }

        public async Task<DescribeClustersInServiceMeshResponse> DescribeClustersInServiceMeshAsync(DescribeClustersInServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClustersInServiceMeshWithOptionsAsync(request, runtime);
        }

        public DescribeIngressGatewaysResponse DescribeIngressGatewaysWithOptions(DescribeIngressGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeIngressGatewaysResponse>(DoRequest("DescribeIngressGateways", "HTTPS", "GET", "2020-01-11", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeIngressGatewaysResponse> DescribeIngressGatewaysWithOptionsAsync(DescribeIngressGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeIngressGatewaysResponse>(await DoRequestAsync("DescribeIngressGateways", "HTTPS", "GET", "2020-01-11", "AK", request.ToMap(), null, runtime));
        }

        public DescribeIngressGatewaysResponse DescribeIngressGateways(DescribeIngressGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIngressGatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeIngressGatewaysResponse> DescribeIngressGatewaysAsync(DescribeIngressGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIngressGatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeUpgradeVersionResponse DescribeUpgradeVersionWithOptions(DescribeUpgradeVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUpgradeVersionResponse>(DoRequest("DescribeUpgradeVersion", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeUpgradeVersionResponse> DescribeUpgradeVersionWithOptionsAsync(DescribeUpgradeVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUpgradeVersionResponse>(await DoRequestAsync("DescribeUpgradeVersion", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeUpgradeVersionResponse DescribeUpgradeVersion(DescribeUpgradeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUpgradeVersionWithOptions(request, runtime);
        }

        public async Task<DescribeUpgradeVersionResponse> DescribeUpgradeVersionAsync(DescribeUpgradeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUpgradeVersionWithOptionsAsync(request, runtime);
        }

        public UpdateMeshFeatureResponse UpdateMeshFeatureWithOptions(UpdateMeshFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMeshFeatureResponse>(DoRequest("UpdateMeshFeature", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateMeshFeatureResponse> UpdateMeshFeatureWithOptionsAsync(UpdateMeshFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMeshFeatureResponse>(await DoRequestAsync("UpdateMeshFeature", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public UpdateMeshFeatureResponse UpdateMeshFeature(UpdateMeshFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMeshFeatureWithOptions(request, runtime);
        }

        public async Task<UpdateMeshFeatureResponse> UpdateMeshFeatureAsync(UpdateMeshFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMeshFeatureWithOptionsAsync(request, runtime);
        }

        public UpgradeMeshVersionResponse UpgradeMeshVersionWithOptions(UpgradeMeshVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpgradeMeshVersionResponse>(DoRequest("UpgradeMeshVersion", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpgradeMeshVersionResponse> UpgradeMeshVersionWithOptionsAsync(UpgradeMeshVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpgradeMeshVersionResponse>(await DoRequestAsync("UpgradeMeshVersion", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public UpgradeMeshVersionResponse UpgradeMeshVersion(UpgradeMeshVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeMeshVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeMeshVersionResponse> UpgradeMeshVersionAsync(UpgradeMeshVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeMeshVersionWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshesResponse DescribeServiceMeshesWithOptions(DescribeServiceMeshesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServiceMeshesResponse>(DoRequest("DescribeServiceMeshes", "HTTPS", "GET", "2020-01-11", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeServiceMeshesResponse> DescribeServiceMeshesWithOptionsAsync(DescribeServiceMeshesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServiceMeshesResponse>(await DoRequestAsync("DescribeServiceMeshes", "HTTPS", "GET", "2020-01-11", "AK", request.ToMap(), null, runtime));
        }

        public DescribeServiceMeshesResponse DescribeServiceMeshes(DescribeServiceMeshesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshesWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshesResponse> DescribeServiceMeshesAsync(DescribeServiceMeshesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshesWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshDetailResponse DescribeServiceMeshDetailWithOptions(DescribeServiceMeshDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServiceMeshDetailResponse>(DoRequest("DescribeServiceMeshDetail", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeServiceMeshDetailResponse> DescribeServiceMeshDetailWithOptionsAsync(DescribeServiceMeshDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServiceMeshDetailResponse>(await DoRequestAsync("DescribeServiceMeshDetail", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeServiceMeshDetailResponse DescribeServiceMeshDetail(DescribeServiceMeshDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshDetailWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshDetailResponse> DescribeServiceMeshDetailAsync(DescribeServiceMeshDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshDetailWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshKubeconfigResponse DescribeServiceMeshKubeconfigWithOptions(DescribeServiceMeshKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServiceMeshKubeconfigResponse>(DoRequest("DescribeServiceMeshKubeconfig", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeServiceMeshKubeconfigResponse> DescribeServiceMeshKubeconfigWithOptionsAsync(DescribeServiceMeshKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServiceMeshKubeconfigResponse>(await DoRequestAsync("DescribeServiceMeshKubeconfig", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DescribeServiceMeshKubeconfigResponse DescribeServiceMeshKubeconfig(DescribeServiceMeshKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshKubeconfigWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshKubeconfigResponse> DescribeServiceMeshKubeconfigAsync(DescribeServiceMeshKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshKubeconfigWithOptionsAsync(request, runtime);
        }

        public CreateServiceMeshResponse CreateServiceMeshWithOptions(CreateServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateServiceMeshResponse>(DoRequest("CreateServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateServiceMeshResponse> CreateServiceMeshWithOptionsAsync(CreateServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateServiceMeshResponse>(await DoRequestAsync("CreateServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public CreateServiceMeshResponse CreateServiceMesh(CreateServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceMeshWithOptions(request, runtime);
        }

        public async Task<CreateServiceMeshResponse> CreateServiceMeshAsync(CreateServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceMeshWithOptionsAsync(request, runtime);
        }

        public DeleteServiceMeshResponse DeleteServiceMeshWithOptions(DeleteServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteServiceMeshResponse>(DoRequest("DeleteServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteServiceMeshResponse> DeleteServiceMeshWithOptionsAsync(DeleteServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteServiceMeshResponse>(await DoRequestAsync("DeleteServiceMesh", "HTTPS", "POST", "2020-01-11", "AK", null, request.ToMap(), runtime));
        }

        public DeleteServiceMeshResponse DeleteServiceMesh(DeleteServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceMeshWithOptions(request, runtime);
        }

        public async Task<DeleteServiceMeshResponse> DeleteServiceMeshAsync(DeleteServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceMeshWithOptionsAsync(request, runtime);
        }

        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

    }
}
