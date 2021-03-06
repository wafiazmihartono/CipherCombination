﻿using System.Linq;
using Common;

namespace AdditiveCipher
{
    public class AdditiveCipher : StringCipher
    {
        private readonly int _key;

        public AdditiveCipher(int key)
        {
            _key = key;
        }

        public override string Encrypt(string plaintext) => string.Join(null,
            from c in plaintext select (char) (Utils.Modulo(c - 65 + _key, 26) + 65));

        public override string Decrypt(string ciphertext) => string.Join(null,
            from c in ciphertext select (char) (Utils.Modulo(c - 65 - _key, 26) + 65));
    }
}