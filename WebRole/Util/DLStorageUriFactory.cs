﻿using ChumBucket.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRole.Util {
    public class DLStorageUriFactory : IDirectUriFactory {
        private IStorageAdapter _adapter;
        public DLStorageUriFactory(IStorageAdapter adapter) {
            this._adapter = adapter;
        }

        public Uri BuildDirectUri(string bucket, string key) {
            var entityUri = new DLEntityUri(bucket: bucket, key: key);
            return entityUri.ToDirectUri(this._adapter.GetAccountName(),
                                         this._adapter.GetContainerName());
        }
    }
}