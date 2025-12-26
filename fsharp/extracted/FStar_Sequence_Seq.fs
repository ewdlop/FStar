#light "off"
module FStar_Sequence_Seq

let rec sequence_of_seq = (fun ( s  :  'a FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Sequence_Base.empty ())
end
| uu___ -> begin
(

let uu___1 = (FStar_Seq_Properties.un_snoc s)
in (match (uu___1) with
| (prefix, last) -> begin
((FStar_Sequence_Base.op_Dollar_Colon_Colon ()) (sequence_of_seq prefix) last)
end))
end))


let rec seq_of_sequence = (fun ( s  :  'a FStar_Sequence_Base.seq ) -> (match ((Prims.op_Equality (FStar_Sequence_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(

let prefix = (FStar_Sequence_Base.take s ((FStar_Sequence_Base.length s) - (Prims.parse_int "1")))
in (FStar_Seq_Properties.snoc (seq_of_sequence prefix) ((FStar_Sequence_Base.op_Dollar_At ()) s ((FStar_Sequence_Base.length s) - (Prims.parse_int "1")))))
end))


type related =
unit




