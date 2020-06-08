<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\Rds\V20140815\Models\DescribeParameterTemplatesResponse\parameters;

use AlibabaCloud\Tea\Model;

class templateRecord extends Model {
    protected $_name = [
        'parameterName' => 'ParameterName',
        'parameterValue' => 'ParameterValue',
        'forceModify' => 'ForceModify',
        'forceRestart' => 'ForceRestart',
        'checkingCode' => 'CheckingCode',
        'parameterDescription' => 'ParameterDescription',
    ];
    public function validate() {
        Model::validateRequired('parameterName', $this->parameterName, true);
        Model::validateRequired('parameterValue', $this->parameterValue, true);
        Model::validateRequired('forceModify', $this->forceModify, true);
        Model::validateRequired('forceRestart', $this->forceRestart, true);
        Model::validateRequired('checkingCode', $this->checkingCode, true);
        Model::validateRequired('parameterDescription', $this->parameterDescription, true);
    }
    public function toMap() {
        $res = [];
        $res['ParameterName'] = $this->parameterName;
        $res['ParameterValue'] = $this->parameterValue;
        $res['ForceModify'] = $this->forceModify;
        $res['ForceRestart'] = $this->forceRestart;
        $res['CheckingCode'] = $this->checkingCode;
        $res['ParameterDescription'] = $this->parameterDescription;
        return $res;
    }
    /**
     * @param array $map
     * @return templateRecord
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['ParameterName'])){
            $model->parameterName = $map['ParameterName'];
        }
        if(isset($map['ParameterValue'])){
            $model->parameterValue = $map['ParameterValue'];
        }
        if(isset($map['ForceModify'])){
            $model->forceModify = $map['ForceModify'];
        }
        if(isset($map['ForceRestart'])){
            $model->forceRestart = $map['ForceRestart'];
        }
        if(isset($map['CheckingCode'])){
            $model->checkingCode = $map['CheckingCode'];
        }
        if(isset($map['ParameterDescription'])){
            $model->parameterDescription = $map['ParameterDescription'];
        }
        return $model;
    }
    /**
     * @description parameterName
     * @var string
     */
    public $parameterName;

    /**
     * @description parameterValue
     * @var string
     */
    public $parameterValue;

    /**
     * @description revisable
     * @var string
     */
    public $forceModify;

    /**
     * @description effective
     * @var string
     */
    public $forceRestart;

    /**
     * @description checkingCode
     * @var string
     */
    public $checkingCode;

    /**
     * @description parameterDescription
     * @var string
     */
    public $parameterDescription;

}
