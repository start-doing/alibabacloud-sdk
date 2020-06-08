<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\Rds\V20140815\Models\DescribeBackupTasksResponse\items;

use AlibabaCloud\Tea\Model;

class backupJob extends Model {
    protected $_name = [
        'backupProgressStatus' => 'BackupProgressStatus',
        'backupStatus' => 'BackupStatus',
        'jobMode' => 'JobMode',
        'process' => 'Process',
        'taskAction' => 'TaskAction',
        'backupJobId' => 'BackupJobId',
        'backupId' => 'BackupId',
    ];
    public function validate() {
        Model::validateRequired('backupProgressStatus', $this->backupProgressStatus, true);
        Model::validateRequired('backupStatus', $this->backupStatus, true);
        Model::validateRequired('jobMode', $this->jobMode, true);
        Model::validateRequired('process', $this->process, true);
        Model::validateRequired('taskAction', $this->taskAction, true);
        Model::validateRequired('backupJobId', $this->backupJobId, true);
        Model::validateRequired('backupId', $this->backupId, true);
    }
    public function toMap() {
        $res = [];
        $res['BackupProgressStatus'] = $this->backupProgressStatus;
        $res['BackupStatus'] = $this->backupStatus;
        $res['JobMode'] = $this->jobMode;
        $res['Process'] = $this->process;
        $res['TaskAction'] = $this->taskAction;
        $res['BackupJobId'] = $this->backupJobId;
        $res['BackupId'] = $this->backupId;
        return $res;
    }
    /**
     * @param array $map
     * @return backupJob
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['BackupProgressStatus'])){
            $model->backupProgressStatus = $map['BackupProgressStatus'];
        }
        if(isset($map['BackupStatus'])){
            $model->backupStatus = $map['BackupStatus'];
        }
        if(isset($map['JobMode'])){
            $model->jobMode = $map['JobMode'];
        }
        if(isset($map['Process'])){
            $model->process = $map['Process'];
        }
        if(isset($map['TaskAction'])){
            $model->taskAction = $map['TaskAction'];
        }
        if(isset($map['BackupJobId'])){
            $model->backupJobId = $map['BackupJobId'];
        }
        if(isset($map['BackupId'])){
            $model->backupId = $map['BackupId'];
        }
        return $model;
    }
    /**
     * @description backupProgressStatus
     * @var string
     */
    public $backupProgressStatus;

    /**
     * @description backupStatus
     * @var string
     */
    public $backupStatus;

    /**
     * @description jobMode
     * @var string
     */
    public $jobMode;

    /**
     * @description process
     * @var string
     */
    public $process;

    /**
     * @description taskAction
     * @var string
     */
    public $taskAction;

    /**
     * @description backupjobId
     * @var string
     */
    public $backupJobId;

    /**
     * @description backupSetID
     * @var string
     */
    public $backupId;

}
