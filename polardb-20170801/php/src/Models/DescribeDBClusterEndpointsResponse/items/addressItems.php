<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Polardb\V20170801\Models\DescribeDBClusterEndpointsResponse\items;

use AlibabaCloud\Tea\Model;

class addressItems extends Model
{
    /**
     * @description connectionString
     *
     * @var string
     */
    public $connectionString;

    /**
     * @description ipAddress
     *
     * @var string
     */
    public $IPAddress;

    /**
     * @description netType
     *
     * @var string
     */
    public $netType;

    /**
     * @description port
     *
     * @var string
     */
    public $port;

    /**
     * @description vpcId
     *
     * @var string
     */
    public $VPCId;

    /**
     * @description vswitchId
     *
     * @var string
     */
    public $VSwitchId;

    /**
     * @description vpcInstanceId
     *
     * @var string
     */
    public $vpcInstanceId;

    /**
     * @description pvtzConnectionString
     *
     * @var string
     */
    public $privateZoneConnectionString;
    protected $_name = [
        'connectionString'            => 'ConnectionString',
        'IPAddress'                   => 'IPAddress',
        'netType'                     => 'NetType',
        'port'                        => 'Port',
        'VPCId'                       => 'VPCId',
        'VSwitchId'                   => 'VSwitchId',
        'vpcInstanceId'               => 'VpcInstanceId',
        'privateZoneConnectionString' => 'PrivateZoneConnectionString',
    ];

    public function validate()
    {
        Model::validateRequired('connectionString', $this->connectionString, true);
        Model::validateRequired('IPAddress', $this->IPAddress, true);
        Model::validateRequired('netType', $this->netType, true);
        Model::validateRequired('port', $this->port, true);
        Model::validateRequired('VPCId', $this->VPCId, true);
        Model::validateRequired('VSwitchId', $this->VSwitchId, true);
        Model::validateRequired('vpcInstanceId', $this->vpcInstanceId, true);
        Model::validateRequired('privateZoneConnectionString', $this->privateZoneConnectionString, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->connectionString) {
            $res['ConnectionString'] = $this->connectionString;
        }
        if (null !== $this->IPAddress) {
            $res['IPAddress'] = $this->IPAddress;
        }
        if (null !== $this->netType) {
            $res['NetType'] = $this->netType;
        }
        if (null !== $this->port) {
            $res['Port'] = $this->port;
        }
        if (null !== $this->VPCId) {
            $res['VPCId'] = $this->VPCId;
        }
        if (null !== $this->VSwitchId) {
            $res['VSwitchId'] = $this->VSwitchId;
        }
        if (null !== $this->vpcInstanceId) {
            $res['VpcInstanceId'] = $this->vpcInstanceId;
        }
        if (null !== $this->privateZoneConnectionString) {
            $res['PrivateZoneConnectionString'] = $this->privateZoneConnectionString;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return addressItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ConnectionString'])) {
            $model->connectionString = $map['ConnectionString'];
        }
        if (isset($map['IPAddress'])) {
            $model->IPAddress = $map['IPAddress'];
        }
        if (isset($map['NetType'])) {
            $model->netType = $map['NetType'];
        }
        if (isset($map['Port'])) {
            $model->port = $map['Port'];
        }
        if (isset($map['VPCId'])) {
            $model->VPCId = $map['VPCId'];
        }
        if (isset($map['VSwitchId'])) {
            $model->VSwitchId = $map['VSwitchId'];
        }
        if (isset($map['VpcInstanceId'])) {
            $model->vpcInstanceId = $map['VpcInstanceId'];
        }
        if (isset($map['PrivateZoneConnectionString'])) {
            $model->privateZoneConnectionString = $map['PrivateZoneConnectionString'];
        }

        return $model;
    }
}
