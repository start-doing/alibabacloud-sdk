<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\Polardb\V20170801\Models;

use AlibabaCloud\Tea\Model;

class ModifyDBEndpointAddressRequest extends Model {
    protected $_name = [
        'accessKeyId' => 'AccessKeyId',
        'ownerId' => 'OwnerId',
        'resourceOwnerAccount' => 'ResourceOwnerAccount',
        'resourceOwnerId' => 'ResourceOwnerId',
        'ownerAccount' => 'OwnerAccount',
        'DBClusterId' => 'DBClusterId',
        'DBEndpointId' => 'DBEndpointId',
        'netType' => 'NetType',
        'connectionStringPrefix' => 'ConnectionStringPrefix',
        'privateZoneAddressPrefix' => 'PrivateZoneAddressPrefix',
        'privateZoneName' => 'PrivateZoneName',
    ];
    public function validate() {
        Model::validateRequired('DBClusterId', $this->DBClusterId, true);
        Model::validateRequired('DBEndpointId', $this->DBEndpointId, true);
        Model::validateRequired('netType', $this->netType, true);
    }
    public function toMap() {
        $res = [];
        $res['AccessKeyId'] = $this->accessKeyId;
        $res['OwnerId'] = $this->ownerId;
        $res['ResourceOwnerAccount'] = $this->resourceOwnerAccount;
        $res['ResourceOwnerId'] = $this->resourceOwnerId;
        $res['OwnerAccount'] = $this->ownerAccount;
        $res['DBClusterId'] = $this->DBClusterId;
        $res['DBEndpointId'] = $this->DBEndpointId;
        $res['NetType'] = $this->netType;
        $res['ConnectionStringPrefix'] = $this->connectionStringPrefix;
        $res['PrivateZoneAddressPrefix'] = $this->privateZoneAddressPrefix;
        $res['PrivateZoneName'] = $this->privateZoneName;
        return $res;
    }
    /**
     * @param array $map
     * @return ModifyDBEndpointAddressRequest
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['AccessKeyId'])){
            $model->accessKeyId = $map['AccessKeyId'];
        }
        if(isset($map['OwnerId'])){
            $model->ownerId = $map['OwnerId'];
        }
        if(isset($map['ResourceOwnerAccount'])){
            $model->resourceOwnerAccount = $map['ResourceOwnerAccount'];
        }
        if(isset($map['ResourceOwnerId'])){
            $model->resourceOwnerId = $map['ResourceOwnerId'];
        }
        if(isset($map['OwnerAccount'])){
            $model->ownerAccount = $map['OwnerAccount'];
        }
        if(isset($map['DBClusterId'])){
            $model->DBClusterId = $map['DBClusterId'];
        }
        if(isset($map['DBEndpointId'])){
            $model->DBEndpointId = $map['DBEndpointId'];
        }
        if(isset($map['NetType'])){
            $model->netType = $map['NetType'];
        }
        if(isset($map['ConnectionStringPrefix'])){
            $model->connectionStringPrefix = $map['ConnectionStringPrefix'];
        }
        if(isset($map['PrivateZoneAddressPrefix'])){
            $model->privateZoneAddressPrefix = $map['PrivateZoneAddressPrefix'];
        }
        if(isset($map['PrivateZoneName'])){
            $model->privateZoneName = $map['PrivateZoneName'];
        }
        return $model;
    }
    /**
     * @description appKey
     * @var string
     */
    public $accessKeyId;

    /**
     * @description ownerId
     * @var integer
     */
    public $ownerId;

    /**
     * @description resourceOwnerAccount
     * @var string
     */
    public $resourceOwnerAccount;

    /**
     * @description resourceOwnerId
     * @var integer
     */
    public $resourceOwnerId;

    /**
     * @description ownerAccount
     * @var string
     */
    public $ownerAccount;

    /**
     * @description dbClusterId
     * @var string
     */
    public $DBClusterId;

    /**
     * @description endpointId
     * @var string
     */
    public $DBEndpointId;

    /**
     * @description netType
     * @var string
     */
    public $netType;

    /**
     * @description connectionStringPrefix
     * @var string
     */
    public $connectionStringPrefix;

    /**
     * @description privateZoneAddressPrefix
     * @var string
     */
    public $privateZoneAddressPrefix;

    /**
     * @description privateZoneName
     * @var string
     */
    public $privateZoneName;

}