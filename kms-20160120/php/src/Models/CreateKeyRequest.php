<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Kms\V20160120\Models;

use AlibabaCloud\Tea\Model;

class CreateKeyRequest extends Model
{
    /**
     * @description desc
     *
     * @var string
     */
    public $description;

    /**
     * @description keyUsage
     *
     * @var string
     */
    public $keyUsage;

    /**
     * @description origin
     *
     * @var string
     */
    public $origin;

    /**
     * @description protectionLevel
     *
     * @var string
     */
    public $protectionLevel;

    /**
     * @description enableAutomaticRotation
     *
     * @var bool
     */
    public $enableAutomaticRotation;

    /**
     * @description rotationInterval
     *
     * @var string
     */
    public $rotationInterval;

    /**
     * @description keySpec
     *
     * @var string
     */
    public $keySpec;
    protected $_name = [
        'description'             => 'Description',
        'keyUsage'                => 'KeyUsage',
        'origin'                  => 'Origin',
        'protectionLevel'         => 'ProtectionLevel',
        'enableAutomaticRotation' => 'EnableAutomaticRotation',
        'rotationInterval'        => 'RotationInterval',
        'keySpec'                 => 'KeySpec',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['Description'] = $this->description;
        }
        if (null !== $this->keyUsage) {
            $res['KeyUsage'] = $this->keyUsage;
        }
        if (null !== $this->origin) {
            $res['Origin'] = $this->origin;
        }
        if (null !== $this->protectionLevel) {
            $res['ProtectionLevel'] = $this->protectionLevel;
        }
        if (null !== $this->enableAutomaticRotation) {
            $res['EnableAutomaticRotation'] = $this->enableAutomaticRotation;
        }
        if (null !== $this->rotationInterval) {
            $res['RotationInterval'] = $this->rotationInterval;
        }
        if (null !== $this->keySpec) {
            $res['KeySpec'] = $this->keySpec;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateKeyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Description'])) {
            $model->description = $map['Description'];
        }
        if (isset($map['KeyUsage'])) {
            $model->keyUsage = $map['KeyUsage'];
        }
        if (isset($map['Origin'])) {
            $model->origin = $map['Origin'];
        }
        if (isset($map['ProtectionLevel'])) {
            $model->protectionLevel = $map['ProtectionLevel'];
        }
        if (isset($map['EnableAutomaticRotation'])) {
            $model->enableAutomaticRotation = $map['EnableAutomaticRotation'];
        }
        if (isset($map['RotationInterval'])) {
            $model->rotationInterval = $map['RotationInterval'];
        }
        if (isset($map['KeySpec'])) {
            $model->keySpec = $map['KeySpec'];
        }

        return $model;
    }
}
