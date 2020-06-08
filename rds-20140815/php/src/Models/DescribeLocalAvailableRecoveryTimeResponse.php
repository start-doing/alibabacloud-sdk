<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\Rds\V20140815\Models;

use AlibabaCloud\Tea\Model;

class DescribeLocalAvailableRecoveryTimeResponse extends Model {
    protected $_name = [
        'requestId' => 'RequestId',
        'DBInstanceId' => 'DBInstanceId',
        'recoveryBeginTime' => 'RecoveryBeginTime',
        'recoveryEndTime' => 'RecoveryEndTime',
    ];
    public function validate() {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('DBInstanceId', $this->DBInstanceId, true);
        Model::validateRequired('recoveryBeginTime', $this->recoveryBeginTime, true);
        Model::validateRequired('recoveryEndTime', $this->recoveryEndTime, true);
    }
    public function toMap() {
        $res = [];
        $res['RequestId'] = $this->requestId;
        $res['DBInstanceId'] = $this->DBInstanceId;
        $res['RecoveryBeginTime'] = $this->recoveryBeginTime;
        $res['RecoveryEndTime'] = $this->recoveryEndTime;
        return $res;
    }
    /**
     * @param array $map
     * @return DescribeLocalAvailableRecoveryTimeResponse
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['RequestId'])){
            $model->requestId = $map['RequestId'];
        }
        if(isset($map['DBInstanceId'])){
            $model->DBInstanceId = $map['DBInstanceId'];
        }
        if(isset($map['RecoveryBeginTime'])){
            $model->recoveryBeginTime = $map['RecoveryBeginTime'];
        }
        if(isset($map['RecoveryEndTime'])){
            $model->recoveryEndTime = $map['RecoveryEndTime'];
        }
        return $model;
    }
    /**
     * @description requestId
     * @var string
     */
    public $requestId;

    /**
     * @description data.dbInstanceName
     * @var string
     */
    public $DBInstanceId;

    /**
     * @description data.recoveryBeginTime
     * @var string
     */
    public $recoveryBeginTime;

    /**
     * @description data.recoveryEndTime
     * @var string
     */
    public $recoveryEndTime;

}
