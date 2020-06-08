<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\Rds\V20140815\Models\DescribeDBInstanceNetInfoResponse;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\Rds\V20140815\Models\DescribeDBInstanceNetInfoResponse\DBInstanceNetInfos\DBInstanceNetInfo;

class DBInstanceNetInfos extends Model {
    protected $_name = [
        'DBInstanceNetInfo' => 'DBInstanceNetInfo',
    ];
    public function validate() {
        Model::validateRequired('DBInstanceNetInfo', $this->DBInstanceNetInfo, true);
    }
    public function toMap() {
        $res = [];
        $res['DBInstanceNetInfo'] = [];
        if(null !== $this->DBInstanceNetInfo && is_array($this->DBInstanceNetInfo)){
            $n = 0;
            foreach($this->DBInstanceNetInfo as $item){
                $res['DBInstanceNetInfo'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        return $res;
    }
    /**
     * @param array $map
     * @return DBInstanceNetInfos
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['DBInstanceNetInfo'])){
            if(!empty($map['DBInstanceNetInfo'])){
                $model->DBInstanceNetInfo = [];
                $n = 0;
                foreach($map['DBInstanceNetInfo'] as $item) {
                    $model->DBInstanceNetInfo[$n++] = null !== $item ? DBInstanceNetInfo::fromMap($item) : $item;
                }
            }
        }
        return $model;
    }
    /**
     * @description DBInstanceNetInfo
     * @var array
     */
    public $DBInstanceNetInfo;

}