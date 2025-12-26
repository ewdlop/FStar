#light "off"
module LowStar_Endianness

type u8 =
FStar_UInt8.t


type u16 =
FStar_UInt16.t


type u32 =
FStar_UInt32.t


type u64 =
FStar_UInt64.t


type u128 =
FStar_UInt128.t


let htole16 : FStar_UInt16.t  ->  FStar_UInt16.t = (fun ( uu___  :  FStar_UInt16.t ) -> (failwith "Not yet implemented: LowStar.Endianness.htole16"))


let le16toh : FStar_UInt16.t  ->  FStar_UInt16.t = (fun ( uu___  :  FStar_UInt16.t ) -> (failwith "Not yet implemented: LowStar.Endianness.le16toh"))


let htole32 : FStar_UInt32.t  ->  FStar_UInt32.t = (fun ( uu___  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.htole32"))


let le32toh : FStar_UInt32.t  ->  FStar_UInt32.t = (fun ( uu___  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.le32toh"))


let htole64 : FStar_UInt64.t  ->  FStar_UInt64.t = (fun ( uu___  :  FStar_UInt64.t ) -> (failwith "Not yet implemented: LowStar.Endianness.htole64"))


let le64toh : FStar_UInt64.t  ->  FStar_UInt64.t = (fun ( uu___  :  FStar_UInt64.t ) -> (failwith "Not yet implemented: LowStar.Endianness.le64toh"))


let htobe16 : FStar_UInt16.t  ->  FStar_UInt16.t = (fun ( uu___  :  FStar_UInt16.t ) -> (failwith "Not yet implemented: LowStar.Endianness.htobe16"))


let be16toh : FStar_UInt16.t  ->  FStar_UInt16.t = (fun ( uu___  :  FStar_UInt16.t ) -> (failwith "Not yet implemented: LowStar.Endianness.be16toh"))


let htobe32 : FStar_UInt32.t  ->  FStar_UInt32.t = (fun ( uu___  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.htobe32"))


let be32toh : FStar_UInt32.t  ->  FStar_UInt32.t = (fun ( uu___  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.be32toh"))


let htobe64 : FStar_UInt64.t  ->  FStar_UInt64.t = (fun ( uu___  :  FStar_UInt64.t ) -> (failwith "Not yet implemented: LowStar.Endianness.htobe64"))


let be64toh : FStar_UInt64.t  ->  FStar_UInt64.t = (fun ( uu___  :  FStar_UInt64.t ) -> (failwith "Not yet implemented: LowStar.Endianness.be64toh"))


type store_pre =
unit


type store_post =
unit


let store16_le_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( z  :  FStar_UInt16.t ) -> (failwith "Not yet implemented: LowStar.Endianness.store16_le_i"))


let load16_le_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.load16_le_i"))


let store16_be_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( z  :  FStar_UInt16.t ) -> (failwith "Not yet implemented: LowStar.Endianness.store16_be_i"))


let load16_be_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.load16_be_i"))


let store32_le_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( z  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.store32_le_i"))


let load32_le_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.load32_le_i"))


let store32_be_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( z  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.store32_be_i"))


let load32_be_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.load32_be_i"))


let store64_le_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( z  :  FStar_UInt64.t ) -> (failwith "Not yet implemented: LowStar.Endianness.store64_le_i"))


let load64_le_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.load64_le_i"))


let store64_be_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( z  :  FStar_UInt64.t ) -> (failwith "Not yet implemented: LowStar.Endianness.store64_be_i"))


let load64_be_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.load64_be_i"))


let store128_le_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( z  :  FStar_UInt128.t ) -> (failwith "Not yet implemented: LowStar.Endianness.store128_le_i"))


let load128_le_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.load128_le_i"))


let store128_be_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( z  :  FStar_UInt128.t ) -> (failwith "Not yet implemented: LowStar.Endianness.store128_be_i"))


let load128_be_i = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (failwith "Not yet implemented: LowStar.Endianness.load128_be_i"))


let store16_le : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt16.t  ->  unit = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) ( z  :  FStar_UInt16.t ) -> (store16_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) z))


let load16_le : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt16.t = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) -> (load16_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let store16_be : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt16.t  ->  unit = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) ( z  :  FStar_UInt16.t ) -> (store16_be_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) z))


let load16_be : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt16.t = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) -> (load16_be_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let store32_le : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt32.t  ->  unit = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) ( z  :  FStar_UInt32.t ) -> (store32_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) z))


let load32_le : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt32.t = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) -> (load32_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let store32_be : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt32.t  ->  unit = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) ( z  :  FStar_UInt32.t ) -> (store32_be_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) z))


let load32_be : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt32.t = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) -> (load32_be_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let store64_le : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt64.t  ->  unit = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) ( z  :  FStar_UInt64.t ) -> (store64_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) z))


let load64_le : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt64.t = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) -> (load64_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let load64_be : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt64.t = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) -> (load64_be_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let store64_be : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt64.t  ->  unit = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) ( z  :  FStar_UInt64.t ) -> (store64_be_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) z))


let load128_le : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt128.t = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) -> (load128_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let store128_le : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt128.t  ->  unit = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) ( z  :  FStar_UInt128.t ) -> (store128_le_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) z))


let load128_be : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt128.t = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) -> (load128_be_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0")))))


let store128_be : FStar_UInt8.t LowStar_Buffer.buffer  ->  FStar_UInt128.t  ->  unit = (fun ( b  :  FStar_UInt8.t LowStar_Buffer.buffer ) ( z  :  FStar_UInt128.t ) -> (store128_be_i b (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))) z))


let index_32_be = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (load32_be_i b (FStar_UInt32.mul (FStar_UInt32.uint_to_t ((Prims.parse_int "4"))) i)))


let index_32_le = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (load32_le_i b (FStar_UInt32.mul (FStar_UInt32.uint_to_t ((Prims.parse_int "4"))) i)))


let index_64_be = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (load64_be_i b (FStar_UInt32.mul (FStar_UInt32.uint_to_t ((Prims.parse_int "8"))) i)))


let index_64_le = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) -> (load64_le_i b (FStar_UInt32.mul (FStar_UInt32.uint_to_t ((Prims.parse_int "8"))) i)))


let upd_32_be = (fun ( b  :  (FStar_UInt8.t, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer ) ( i  :  FStar_UInt32.t ) ( v  :  FStar_UInt32.t ) -> (

let h0 = (FStar_HyperStack_ST.get ())
in ((store32_be_i b (FStar_UInt32.mul (FStar_UInt32.uint_to_t ((Prims.parse_int "4"))) i) v);
(

let h1 = (FStar_HyperStack_ST.get ())
in ());
)))




