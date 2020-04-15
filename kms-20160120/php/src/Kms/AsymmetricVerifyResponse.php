<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Kms\V20160120\Kms;

use AlibabaCloud\Tea\Model;

class AsymmetricVerifyResponse extends Model
{
    /**
     * @description value
     *
     * @var bool
     */
    public $value;
    /**
     * @description keyId
     *
     * @var string
     */
    public $keyId;
    /**
     * @description requestId
     *
     * @var string
     */
    public $requestId;
    /**
     * @description keyVersionId
     *
     * @var string
     */
    public $keyVersionId;
    protected $_name = [
        'value'        => 'Value',
        'keyId'        => 'KeyId',
        'requestId'    => 'RequestId',
        'keyVersionId' => 'KeyVersionId',
    ];

    public function validate()
    {
        Model::validateRequired('value', $this->value, true);
        Model::validateRequired('keyId', $this->keyId, true);
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('keyVersionId', $this->keyVersionId, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['Value']        = $this->value;
        $res['KeyId']        = $this->keyId;
        $res['RequestId']    = $this->requestId;
        $res['KeyVersionId'] = $this->keyVersionId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AsymmetricVerifyResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Value'])) {
            $model->value = $map['Value'];
        }
        if (isset($map['KeyId'])) {
            $model->keyId = $map['KeyId'];
        }
        if (isset($map['RequestId'])) {
            $model->requestId = $map['RequestId'];
        }
        if (isset($map['KeyVersionId'])) {
            $model->keyVersionId = $map['KeyVersionId'];
        }

        return $model;
    }
}