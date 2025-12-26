#light "off"
module FStar_Endianness

type bytes =
FStar_UInt8.t FStar_Seq_Base.seq


let rec le_to_n : bytes  ->  Prims.nat = (fun ( b  :  bytes ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length b) (Prims.parse_int "0"))) with
| true -> begin
(Prims.parse_int "0")
end
| uu___ -> begin
((FStar_UInt8.v (FStar_Seq_Properties.head b)) + ((Prims.pow2 (Prims.parse_int "8")) * (le_to_n (FStar_Seq_Properties.tail b))))
end))


let rec be_to_n : bytes  ->  Prims.nat = (fun ( b  :  bytes ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length b) (Prims.parse_int "0"))) with
| true -> begin
(Prims.parse_int "0")
end
| uu___ -> begin
((FStar_UInt8.v (FStar_Seq_Properties.last b)) + ((Prims.pow2 (Prims.parse_int "8")) * (be_to_n (FStar_Seq_Base.slice b (Prims.parse_int "0") ((FStar_Seq_Base.length b) - (Prims.parse_int "1"))))))
end))


let rec n_to_le : Prims.nat  ->  Prims.nat  ->  bytes = (fun ( len  :  Prims.nat ) ( n  :  Prims.nat ) -> (match ((Prims.op_Equality len (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(

let len1 = (len - (Prims.parse_int "1"))
in (

let byte = (FStar_UInt8.uint_to_t (Prims.mod_f n (Prims.parse_int "256")))
in (

let n' = (n / (Prims.parse_int "256"))
in (

let b' = (n_to_le len1 n')
in (

let b = (FStar_Seq_Base.cons byte b')
in b)))))
end))


let rec n_to_be : Prims.nat  ->  Prims.nat  ->  bytes = (fun ( len  :  Prims.nat ) ( n  :  Prims.nat ) -> (match ((Prims.op_Equality len (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(

let len1 = (len - (Prims.parse_int "1"))
in (

let byte = (FStar_UInt8.uint_to_t (Prims.mod_f n (Prims.parse_int "256")))
in (

let n' = (n / (Prims.parse_int "256"))
in (

let b' = (n_to_be len1 n')
in (

let b'' = (FStar_Seq_Base.create (Prims.parse_int "1") byte)
in (

let b = (FStar_Seq_Base.append b' b'')
in b))))))
end))


let uint32_of_le : bytes  ->  FStar_UInt32.t = (fun ( b  :  bytes ) -> (

let n = (le_to_n b)
in (FStar_UInt32.uint_to_t n)))


let le_of_uint32 : FStar_UInt32.t  ->  bytes = (fun ( x  :  FStar_UInt32.t ) -> (n_to_le (Prims.parse_int "4") (FStar_UInt32.v x)))


let uint32_of_be : bytes  ->  FStar_UInt32.t = (fun ( b  :  bytes ) -> (

let n = (be_to_n b)
in (FStar_UInt32.uint_to_t n)))


let be_of_uint32 : FStar_UInt32.t  ->  bytes = (fun ( x  :  FStar_UInt32.t ) -> (n_to_be (Prims.parse_int "4") (FStar_UInt32.v x)))


let uint64_of_le : bytes  ->  FStar_UInt64.t = (fun ( b  :  bytes ) -> (

let n = (le_to_n b)
in (FStar_UInt64.uint_to_t n)))


let le_of_uint64 : FStar_UInt64.t  ->  bytes = (fun ( x  :  FStar_UInt64.t ) -> (n_to_le (Prims.parse_int "8") (FStar_UInt64.v x)))


let uint64_of_be : bytes  ->  FStar_UInt64.t = (fun ( b  :  bytes ) -> (

let n = (be_to_n b)
in (FStar_UInt64.uint_to_t n)))


let be_of_uint64 : FStar_UInt64.t  ->  bytes = (fun ( x  :  FStar_UInt64.t ) -> (n_to_be (Prims.parse_int "8") (FStar_UInt64.v x)))


let rec seq_uint32_of_le : Prims.nat  ->  bytes  ->  FStar_UInt32.t FStar_Seq_Base.seq = (fun ( l  :  Prims.nat ) ( b  :  bytes ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length b) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(

let uu___1 = (FStar_Seq_Properties.split b (Prims.parse_int "4"))
in (match (uu___1) with
| (hd, tl) -> begin
(FStar_Seq_Base.cons (uint32_of_le hd) (seq_uint32_of_le (l - (Prims.parse_int "1")) tl))
end))
end))


let rec le_of_seq_uint32 : FStar_UInt32.t FStar_Seq_Base.seq  ->  bytes = (fun ( s  :  FStar_UInt32.t FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(FStar_Seq_Base.append (le_of_uint32 (FStar_Seq_Properties.head s)) (le_of_seq_uint32 (FStar_Seq_Properties.tail s)))
end))


let rec seq_uint32_of_be : Prims.nat  ->  bytes  ->  FStar_UInt32.t FStar_Seq_Base.seq = (fun ( l  :  Prims.nat ) ( b  :  bytes ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length b) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(

let uu___1 = (FStar_Seq_Properties.split b (Prims.parse_int "4"))
in (match (uu___1) with
| (hd, tl) -> begin
(FStar_Seq_Base.cons (uint32_of_be hd) (seq_uint32_of_be (l - (Prims.parse_int "1")) tl))
end))
end))


let rec be_of_seq_uint32 : FStar_UInt32.t FStar_Seq_Base.seq  ->  bytes = (fun ( s  :  FStar_UInt32.t FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(FStar_Seq_Base.append (be_of_uint32 (FStar_Seq_Properties.head s)) (be_of_seq_uint32 (FStar_Seq_Properties.tail s)))
end))


let rec seq_uint64_of_le : Prims.nat  ->  bytes  ->  FStar_UInt64.t FStar_Seq_Base.seq = (fun ( l  :  Prims.nat ) ( b  :  bytes ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length b) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(

let uu___1 = (FStar_Seq_Properties.split b (Prims.parse_int "8"))
in (match (uu___1) with
| (hd, tl) -> begin
(FStar_Seq_Base.cons (uint64_of_le hd) (seq_uint64_of_le (l - (Prims.parse_int "1")) tl))
end))
end))


let rec le_of_seq_uint64 : FStar_UInt64.t FStar_Seq_Base.seq  ->  bytes = (fun ( s  :  FStar_UInt64.t FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(FStar_Seq_Base.append (le_of_uint64 (FStar_Seq_Properties.head s)) (le_of_seq_uint64 (FStar_Seq_Properties.tail s)))
end))


let rec seq_uint64_of_be : Prims.nat  ->  bytes  ->  FStar_UInt64.t FStar_Seq_Base.seq = (fun ( l  :  Prims.nat ) ( b  :  bytes ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length b) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(

let uu___1 = (FStar_Seq_Properties.split b (Prims.parse_int "8"))
in (match (uu___1) with
| (hd, tl) -> begin
(FStar_Seq_Base.cons (uint64_of_be hd) (seq_uint64_of_be (l - (Prims.parse_int "1")) tl))
end))
end))


let rec be_of_seq_uint64 : FStar_UInt64.t FStar_Seq_Base.seq  ->  bytes = (fun ( s  :  FStar_UInt64.t FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(FStar_Seq_Base.append (be_of_uint64 (FStar_Seq_Properties.head s)) (be_of_seq_uint64 (FStar_Seq_Properties.tail s)))
end))




