<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\Rds\V20140815\Models\DescibeImportsFromDatabaseResponse;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\Rds\V20140815\Models\DescibeImportsFromDatabaseResponse\items\importResultFromDB;

class items extends Model {
    protected $_name = [
        'importResultFromDB' => 'ImportResultFromDB',
    ];
    public function validate() {
        Model::validateRequired('importResultFromDB', $this->importResultFromDB, true);
    }
    public function toMap() {
        $res = [];
        $res['ImportResultFromDB'] = [];
        if(null !== $this->importResultFromDB && is_array($this->importResultFromDB)){
            $n = 0;
            foreach($this->importResultFromDB as $item){
                $res['ImportResultFromDB'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if(isset($map['ImportResultFromDB'])){
            if(!empty($map['ImportResultFromDB'])){
                $model->importResultFromDB = [];
                $n = 0;
                foreach($map['ImportResultFromDB'] as $item) {
                    $model->importResultFromDB[$n++] = null !== $item ? importResultFromDB::fromMap($item) : $item;
                }
            }
        }
        return $model;
    }
    /**
     * @description ImportResultFromDB
     * @var array
     */
    public $importResultFromDB;

}
