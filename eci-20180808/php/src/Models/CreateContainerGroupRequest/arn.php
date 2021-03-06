<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Eci\V20180808\Models\CreateContainerGroupRequest;

use AlibabaCloud\Tea\Model;

class arn extends Model
{
    /**
     * @description roleArn
     *
     * @var string
     */
    public $roleArn;

    /**
     * @description roleType
     *
     * @var string
     */
    public $roleType;

    /**
     * @description assumeRoleFor
     *
     * @var string
     */
    public $assumeRoleFor;
    protected $_name = [
        'roleArn'       => 'RoleArn',
        'roleType'      => 'RoleType',
        'assumeRoleFor' => 'AssumeRoleFor',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleArn) {
            $res['RoleArn'] = $this->roleArn;
        }
        if (null !== $this->roleType) {
            $res['RoleType'] = $this->roleType;
        }
        if (null !== $this->assumeRoleFor) {
            $res['AssumeRoleFor'] = $this->assumeRoleFor;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return arn
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['RoleArn'])) {
            $model->roleArn = $map['RoleArn'];
        }
        if (isset($map['RoleType'])) {
            $model->roleType = $map['RoleType'];
        }
        if (isset($map['AssumeRoleFor'])) {
            $model->assumeRoleFor = $map['AssumeRoleFor'];
        }

        return $model;
    }
}
