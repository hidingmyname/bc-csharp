namespace Org.BouncyCastle.Bcpg
{
    /// <summary>Basic tags for symmetric key algorithms.</summary>
    public enum SymmetricKeyAlgorithmTag
    {
        /// <summary>Plaintext or unencrypted data.</summary>
        Null = 0,         // Plaintext or unencrypted data
        /// <summary>IDEA [IDEA].</summary>
        Idea = 1,         // IDEA [IDEA]
        /// <summary>Triple-DES (DES-EDE, as per spec -168 bit key derived from 192).</summary>
        TripleDes = 2,    // Triple-DES (DES-EDE, as per spec -168 bit key derived from 192)
        /// <summary>Cast5 (128 bit key, as per RFC 2144).</summary>
        Cast5 = 3,        // Cast5 (128 bit key, as per RFC 2144)
        /// <summary>Blowfish (128 bit key, 16 rounds) [Blowfish].</summary>
        Blowfish = 4,     // Blowfish (128 bit key, 16 rounds) [Blowfish]
        /// <summary>Reserved for SAFER-SK128 (13 rounds).</summary>
        Safer = 5,        // Reserved for SAFER-SK128 (13 rounds)
        /// <summary>Reserved for DES/SK.</summary>
        Des = 6,          // Reserved for DES/SK
        /// <summary>AES with 128-bit key.</summary>
        Aes128 = 7,       // AES with 128-bit key
        /// <summary>AES with 192-bit key.</summary>
        Aes192 = 8,       // AES with 192-bit key
        /// <summary>AES with 256-bit key.</summary>
        Aes256 = 9,       // AES with 256-bit key
        /// <summary>Twofish with 256-bit key.</summary>
        Twofish = 10,     // Twofish with 256-bit key
        /// <summary>Camellia with 128-bit key.</summary>
        Camellia128 = 11, // Camellia with 128-bit key
        /// <summary>Camellia with 192-bit key.</summary>
        Camellia192 = 12, // Camellia with 192-bit key
        /// <summary>Camellia with 256-bit key.</summary>
        Camellia256 = 13  // Camellia with 256-bit key
    }
}
