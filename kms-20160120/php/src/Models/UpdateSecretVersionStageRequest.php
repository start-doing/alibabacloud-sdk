<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Kms\V20160120\Models;

use AlibabaCloud\Tea\Model;

class UpdateSecretVersionStageRequest extends Model
{
    /**
     * @description SecretName
     *
     * @var string
     */
    public $secretName;

    /**
     * @description VersionStage
     *
     * @var string
     */
    public $versionStage;

    /**
     * @description RemoveFromVersion
     *
     * @var string
     */
    public $removeFromVersion;

    /**
     * @description MoveToVersion
     *
     * @var string
     */
    public $moveToVersion;
    protected $_name = [
        'secretName'        => 'SecretName',
        'versionStage'      => 'VersionStage',
        'removeFromVersion' => 'RemoveFromVersion',
        'moveToVersion'     => 'MoveToVersion',
    ];

    public function validate()
    {
        Model::validateRequired('secretName', $this->secretName, true);
        Model::validateRequired('versionStage', $this->versionStage, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->secretName) {
            $res['SecretName'] = $this->secretName;
        }
        if (null !== $this->versionStage) {
            $res['VersionStage'] = $this->versionStage;
        }
        if (null !== $this->removeFromVersion) {
            $res['RemoveFromVersion'] = $this->removeFromVersion;
        }
        if (null !== $this->moveToVersion) {
            $res['MoveToVersion'] = $this->moveToVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateSecretVersionStageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['SecretName'])) {
            $model->secretName = $map['SecretName'];
        }
        if (isset($map['VersionStage'])) {
            $model->versionStage = $map['VersionStage'];
        }
        if (isset($map['RemoveFromVersion'])) {
            $model->removeFromVersion = $map['RemoveFromVersion'];
        }
        if (isset($map['MoveToVersion'])) {
            $model->moveToVersion = $map['MoveToVersion'];
        }

        return $model;
    }
}
