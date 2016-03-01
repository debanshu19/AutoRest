# coding=utf-8
# --------------------------------------------------------------------------
# --------------------------------------------------------------------------

from msrest.serialization import Model


class CustomDomain(Model):
    """
    The custom domain assigned to this storage account. This can be set via
    Update.

    :param str name: Gets or sets the custom domain name. Name is the CNAME
     source.
    :param bool use_sub_domain: Indicates whether indirect CName validation
     is enabled. Default value is false. This should only be set on updates
    """

    _required = ['name']

    _attribute_map = {
        'name': {'key': 'name', 'type': 'str'},
        'use_sub_domain': {'key': 'useSubDomain', 'type': 'bool'},
    }

    def __init__(self, name, use_sub_domain=None):
        self.name = name
        self.use_sub_domain = use_sub_domain
