<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\Rds\V20140815\Models\DescribeDBInstanceAttributeResponse;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\Rds\V20140815\Models\DescribeDBInstanceAttributeResponse\items\DBInstanceAttribute;

class items extends Model {
    protected $_name = [
        'DBInstanceAttribute' => 'DBInstanceAttribute',
    ];
    public function validate() {
        Model::validateRequired('DBInstanceAttribute', $this->DBInstanceAttribute, true);
    }
    public function toMap() {
        $res = [];
        $res['DBInstanceAttribute'] = [];
        if(null !== $this->DBInstanceAttribute && is_array($this->DBInstanceAttribute)){
            $n = 0;
            foreach($this->DBInstanceAttribute as $item){
                $res['DBInstanceAttribute'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        return $res;
    }
    /**
     * @param array $map
     * @return items
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['DBInstanceAttribute'])){
            if(!empty($map['DBInstanceAttribute'])){
                $model->DBInstanceAttribute = [];
                $n = 0;
                foreach($map['DBInstanceAttribute'] as $item) {
                    $model->DBInstanceAttribute[$n++] = null !== $item ? DBInstanceAttribute::fromMap($item) : $item;
                }
            }
        }
        return $model;
    }
    /**
     * @description DBInstanceAttribute
     * @var array
     */
    public $DBInstanceAttribute;

}
