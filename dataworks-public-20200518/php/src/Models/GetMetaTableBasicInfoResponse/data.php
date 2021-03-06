<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dataworkspublic\V20200518\Models\GetMetaTableBasicInfoResponse;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description name
     *
     * @var string
     */
    public $tableName;

    /**
     * @description tableGuid
     *
     * @var string
     */
    public $tableGuid;

    /**
     * @description ownerId
     *
     * @var string
     */
    public $ownerId;

    /**
     * @description tenantId
     *
     * @var int
     */
    public $tenantId;

    /**
     * @description projectId
     *
     * @var int
     */
    public $projectId;

    /**
     * @description createTime
     *
     * @var int
     */
    public $createTime;

    /**
     * @description lastModifyTime
     *
     * @var int
     */
    public $lastModifyTime;

    /**
     * @description lifeCycle
     *
     * @var int
     */
    public $lifeCycle;

    /**
     * @description isVisible
     *
     * @var int
     */
    public $isVisible;

    /**
     * @description lastDdlTime
     *
     * @var int
     */
    public $lastDdlTime;

    /**
     * @description lastAccessTime
     *
     * @var int
     */
    public $lastAccessTime;

    /**
     * @description envType
     *
     * @var int
     */
    public $envType;

    /**
     * @description dataSize
     *
     * @var int
     */
    public $dataSize;

    /**
     * @description comment
     *
     * @var string
     */
    public $comment;

    /**
     * @description projectName
     *
     * @var string
     */
    public $projectName;
    protected $_name = [
        'tableName'      => 'TableName',
        'tableGuid'      => 'TableGuid',
        'ownerId'        => 'OwnerId',
        'tenantId'       => 'TenantId',
        'projectId'      => 'ProjectId',
        'createTime'     => 'CreateTime',
        'lastModifyTime' => 'LastModifyTime',
        'lifeCycle'      => 'LifeCycle',
        'isVisible'      => 'IsVisible',
        'lastDdlTime'    => 'LastDdlTime',
        'lastAccessTime' => 'LastAccessTime',
        'envType'        => 'EnvType',
        'dataSize'       => 'DataSize',
        'comment'        => 'Comment',
        'projectName'    => 'ProjectName',
    ];

    public function validate()
    {
        Model::validateRequired('tableName', $this->tableName, true);
        Model::validateRequired('tableGuid', $this->tableGuid, true);
        Model::validateRequired('ownerId', $this->ownerId, true);
        Model::validateRequired('tenantId', $this->tenantId, true);
        Model::validateRequired('projectId', $this->projectId, true);
        Model::validateRequired('createTime', $this->createTime, true);
        Model::validateRequired('lastModifyTime', $this->lastModifyTime, true);
        Model::validateRequired('lifeCycle', $this->lifeCycle, true);
        Model::validateRequired('isVisible', $this->isVisible, true);
        Model::validateRequired('lastDdlTime', $this->lastDdlTime, true);
        Model::validateRequired('lastAccessTime', $this->lastAccessTime, true);
        Model::validateRequired('envType', $this->envType, true);
        Model::validateRequired('dataSize', $this->dataSize, true);
        Model::validateRequired('comment', $this->comment, true);
        Model::validateRequired('projectName', $this->projectName, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tableName) {
            $res['TableName'] = $this->tableName;
        }
        if (null !== $this->tableGuid) {
            $res['TableGuid'] = $this->tableGuid;
        }
        if (null !== $this->ownerId) {
            $res['OwnerId'] = $this->ownerId;
        }
        if (null !== $this->tenantId) {
            $res['TenantId'] = $this->tenantId;
        }
        if (null !== $this->projectId) {
            $res['ProjectId'] = $this->projectId;
        }
        if (null !== $this->createTime) {
            $res['CreateTime'] = $this->createTime;
        }
        if (null !== $this->lastModifyTime) {
            $res['LastModifyTime'] = $this->lastModifyTime;
        }
        if (null !== $this->lifeCycle) {
            $res['LifeCycle'] = $this->lifeCycle;
        }
        if (null !== $this->isVisible) {
            $res['IsVisible'] = $this->isVisible;
        }
        if (null !== $this->lastDdlTime) {
            $res['LastDdlTime'] = $this->lastDdlTime;
        }
        if (null !== $this->lastAccessTime) {
            $res['LastAccessTime'] = $this->lastAccessTime;
        }
        if (null !== $this->envType) {
            $res['EnvType'] = $this->envType;
        }
        if (null !== $this->dataSize) {
            $res['DataSize'] = $this->dataSize;
        }
        if (null !== $this->comment) {
            $res['Comment'] = $this->comment;
        }
        if (null !== $this->projectName) {
            $res['ProjectName'] = $this->projectName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['TableName'])) {
            $model->tableName = $map['TableName'];
        }
        if (isset($map['TableGuid'])) {
            $model->tableGuid = $map['TableGuid'];
        }
        if (isset($map['OwnerId'])) {
            $model->ownerId = $map['OwnerId'];
        }
        if (isset($map['TenantId'])) {
            $model->tenantId = $map['TenantId'];
        }
        if (isset($map['ProjectId'])) {
            $model->projectId = $map['ProjectId'];
        }
        if (isset($map['CreateTime'])) {
            $model->createTime = $map['CreateTime'];
        }
        if (isset($map['LastModifyTime'])) {
            $model->lastModifyTime = $map['LastModifyTime'];
        }
        if (isset($map['LifeCycle'])) {
            $model->lifeCycle = $map['LifeCycle'];
        }
        if (isset($map['IsVisible'])) {
            $model->isVisible = $map['IsVisible'];
        }
        if (isset($map['LastDdlTime'])) {
            $model->lastDdlTime = $map['LastDdlTime'];
        }
        if (isset($map['LastAccessTime'])) {
            $model->lastAccessTime = $map['LastAccessTime'];
        }
        if (isset($map['EnvType'])) {
            $model->envType = $map['EnvType'];
        }
        if (isset($map['DataSize'])) {
            $model->dataSize = $map['DataSize'];
        }
        if (isset($map['Comment'])) {
            $model->comment = $map['Comment'];
        }
        if (isset($map['ProjectName'])) {
            $model->projectName = $map['ProjectName'];
        }

        return $model;
    }
}
