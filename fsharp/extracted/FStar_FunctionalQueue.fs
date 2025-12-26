#light "off"
module FStar_FunctionalQueue

type 'a queue =
('a Prims.list * 'a Prims.list)


let empty = (fun ( uu___  :  unit ) -> (([]), ([])))


let queue_to_list = (fun ( q  :  'a queue ) -> (match ((FStar_Pervasives_Native.fst q)) with
| [] -> begin
[]
end
| uu___ -> begin
(FStar_List_Tot_Base.op_At (FStar_Pervasives_Native.fst q) (FStar_List_Tot_Base.rev (FStar_Pervasives_Native.snd q)))
end))


let queue_of_list = (fun ( l  :  'a Prims.list ) -> (match (l) with
| [] -> begin
(empty ())
end
| uu___ -> begin
((l), ([]))
end))


let queue_to_seq = (fun ( q  :  'a queue ) -> (FStar_Seq_Base.seq_of_list (queue_to_list q)))


let queue_of_seq = (fun ( s  :  'a FStar_Seq_Base.seq ) -> (queue_of_list (FStar_Seq_Base.seq_to_list s)))



type not_empty =
unit


let enqueue = (fun ( x  :  'a ) ( q  :  'a queue ) -> (match ((FStar_Pervasives_Native.fst q)) with
| [] -> begin
(((x)::[]), ([]))
end
| l -> begin
((l), ((x)::(FStar_Pervasives_Native.snd q)))
end))


let dequeue = (fun ( q  :  'a queue ) -> (

let uu___ = (FStar_Pervasives_Native.fst q)
in (match (uu___) with
| (hd)::tl -> begin
(match (tl) with
| [] -> begin
((hd), ((((FStar_List_Tot_Base.rev (FStar_Pervasives_Native.snd q))), ([]))))
end
| uu___1 -> begin
((hd), (((tl), ((FStar_Pervasives_Native.snd q)))))
end)
end)))


let peek = (fun ( q  :  'a queue ) -> (FStar_List_Tot_Base.hd (FStar_Pervasives_Native.fst q)))




