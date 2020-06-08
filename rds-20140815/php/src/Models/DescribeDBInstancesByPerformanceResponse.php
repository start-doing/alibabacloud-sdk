<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\Rds\V20140815\Models;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\Rds\V20140815\Models\DescribeDBInstancesByPerformanceResponse\items;

class DescribeDBInstancesByPerformanceResponse extends Model {
    protected $_name = [
        'requestId' => 'RequestId',
        'pageNumber' => 'PageNumber',
        'totalRecordCount' => 'TotalRecordCount',
        'pageRecordCount' => 'PageRecordCount',
        'items' => 'Items',
    ];
    public function validate() {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('pageNumber', $this->pageNumber, true);
        Model::validateRequired('totalRecordCount', $this->totalRecordCount, true);
        Model::validateRequired('pageRecordCount', $this->pageRecordCount, true);
        Model::validateRequired('items', $this->items, true);
    }
    public function toMap() {
        $res = [];
        $res['RequestId'] = $this->requestId;
        $res['PageNumber'] = $this->pageNumber;
        $res['TotalRecordCount'] = $this->totalRecordCount;
        $res['PageRecordCount'] = $this->pageRecordCount;
        $res['Items'] = null !== $this->items ? $this->items->toMap() : null;
        return $res;
    }
    /**
     * @param array $map
     * @return DescribeDBInstancesByPerformanceResponse
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['RequestId'])){
            $model->requestId = $map['RequestId'];
        }
        if(isset($map['PageNumber'])){
            $model->pageNumber = $map['PageNumber'];
        }
        if(isset($map['TotalRecordCount'])){
            $model->totalRecordCount = $map['TotalRecordCount'];
        }
        if(isset($map['PageRecordCount'])){
            $model->pageRecordCount = $map['PageRecordCount'];
        }
        if(isset($map['Items'])){
            $model->items = items::fromMap($map['Items']);
        }
        return $model;
    }
    /**
     * @description requestId
     * @var string
     */
    public $requestId;

    /**
     * @description data.pageNumbers
     * @var integer
     */
    public $pageNumber;

    /**
     * @description data.totalRecords
     * @var integer
     */
    public $totalRecordCount;

    /**
     * @description data.performanceCount
     * @var integer
     */
    public $pageRecordCount;

    /**
     * @description data.performanceList
     * @var items
     */
    public $items;

}
