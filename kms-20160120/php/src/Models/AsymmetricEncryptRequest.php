<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Kms\V20160120\Models;

use AlibabaCloud\Tea\Model;

class AsymmetricEncryptRequest extends Model
{
    /**
     * @description Plaintext
     *
     * @var string
     */
    public $plaintext;

    /**
     * @description KeyId
     *
     * @var string
     */
    public $keyId;

    /**
     * @description KeyVersionId
     *
     * @var string
     */
    public $keyVersionId;

    /**
     * @description Algorithm
     *
     * @var string
     */
    public $algorithm;
    protected $_name = [
        'plaintext'    => 'Plaintext',
        'keyId'        => 'KeyId',
        'keyVersionId' => 'KeyVersionId',
        'algorithm'    => 'Algorithm',
    ];

    public function validate()
    {
        Model::validateRequired('plaintext', $this->plaintext, true);
        Model::validateRequired('keyId', $this->keyId, true);
        Model::validateRequired('keyVersionId', $this->keyVersionId, true);
        Model::validateRequired('algorithm', $this->algorithm, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->plaintext) {
            $res['Plaintext'] = $this->plaintext;
        }
        if (null !== $this->keyId) {
            $res['KeyId'] = $this->keyId;
        }
        if (null !== $this->keyVersionId) {
            $res['KeyVersionId'] = $this->keyVersionId;
        }
        if (null !== $this->algorithm) {
            $res['Algorithm'] = $this->algorithm;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AsymmetricEncryptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Plaintext'])) {
            $model->plaintext = $map['Plaintext'];
        }
        if (isset($map['KeyId'])) {
            $model->keyId = $map['KeyId'];
        }
        if (isset($map['KeyVersionId'])) {
            $model->keyVersionId = $map['KeyVersionId'];
        }
        if (isset($map['Algorithm'])) {
            $model->algorithm = $map['Algorithm'];
        }

        return $model;
    }
}
