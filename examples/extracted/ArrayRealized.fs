#light "off"
module ArrayRealized
type 'a contents =
| Const of 'a
| Upd of Prims.int * 'a * 'a contents
| Append of 'a seq * 'a seq 
 and 'a seq =
| Seq of 'a contents * Prims.nat * Prims.nat


let uu___is_Const = (fun ( projectee  :  'a contents ) -> (match (projectee) with
| Const (v) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Const__item__v = (fun ( projectee  :  'a contents ) -> (match (projectee) with
| Const (v) -> begin
v
end))


let uu___is_Upd = (fun ( projectee  :  'a contents ) -> (match (projectee) with
| Upd (ix, v, tl) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Upd__item__ix = (fun ( projectee  :  'a contents ) -> (match (projectee) with
| Upd (ix, v, tl) -> begin
ix
end))


let __proj__Upd__item__v = (fun ( projectee  :  'a contents ) -> (match (projectee) with
| Upd (ix, v, tl) -> begin
v
end))


let __proj__Upd__item__tl = (fun ( projectee  :  'a contents ) -> (match (projectee) with
| Upd (ix, v, tl) -> begin
tl
end))


let uu___is_Append = (fun ( projectee  :  'a contents ) -> (match (projectee) with
| Append (s1, s2) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Append__item__s1 = (fun ( projectee  :  'a contents ) -> (match (projectee) with
| Append (s1, s2) -> begin
s1
end))


let __proj__Append__item__s2 = (fun ( projectee  :  'a contents ) -> (match (projectee) with
| Append (s1, s2) -> begin
s2
end))


let uu___is_Seq = (fun ( projectee  :  'a seq ) -> true)


let __proj__Seq__item__c = (fun ( projectee  :  'a seq ) -> (match (projectee) with
| Seq (c, start_i, end_i) -> begin
c
end))


let __proj__Seq__item__start_i = (fun ( projectee  :  'a seq ) -> (match (projectee) with
| Seq (c, start_i, end_i) -> begin
start_i
end))


let __proj__Seq__item__end_i = (fun ( projectee  :  'a seq ) -> (match (projectee) with
| Seq (c, start_i, end_i) -> begin
end_i
end))


let create = (fun ( n  :  Prims.nat ) ( init  :  'a ) -> Seq (Const (init), (Prims.parse_int "0"), n))


let length = (fun ( s  :  'a seq ) -> ((__proj__Seq__item__end_i s) - (__proj__Seq__item__start_i s)))


let rec __index__ = (fun ( c  :  'a contents ) ( i  :  Prims.int ) -> (match (c) with
| Const (v) -> begin
v
end
| Upd (j, v, tl) -> begin
(match ((Prims.op_Equality i j)) with
| true -> begin
v
end
| uu___ -> begin
(__index__ tl i)
end)
end
| Append (s1, s2) -> begin
(match ((i < (length s1))) with
| true -> begin
(__index__ (__proj__Seq__item__c s1) i)
end
| uu___ -> begin
(__index__ (__proj__Seq__item__c s2) (i - (length s1)))
end)
end))


let index = (fun ( uu___  :  'a seq ) ( i  :  Prims.nat ) -> (match (uu___) with
| Seq (c, j, k) -> begin
(__index__ c (i + j))
end))


let rec __update__ = (fun ( c  :  'a contents ) ( i  :  Prims.int ) ( v  :  'a ) -> (match (c) with
| Const (uu___) -> begin
Upd (i, v, c)
end
| Upd (uu___, uu___1, uu___2) -> begin
Upd (i, v, c)
end
| Append (s1, s2) -> begin
(match ((i < (length s1))) with
| true -> begin
Append (Seq ((__update__ (__proj__Seq__item__c s1) i v), (__proj__Seq__item__start_i s1), (__proj__Seq__item__end_i s1)), s2)
end
| uu___ -> begin
Append (s1, Seq ((__update__ (__proj__Seq__item__c s2) (i - (length s1)) v), (__proj__Seq__item__start_i s2), (__proj__Seq__item__end_i s2)))
end)
end))


let update = (fun ( uu___  :  'a seq ) ( i  :  Prims.nat ) ( v  :  'a ) -> (match (uu___) with
| Seq (c, j, k) -> begin
Seq ((__update__ c (i + j) v), j, k)
end))


let slice = (fun ( uu___  :  'a seq ) ( i  :  Prims.nat ) ( j  :  Prims.nat ) -> (match (uu___) with
| Seq (c, start_i, end_i) -> begin
Seq (c, (start_i + i), (start_i + j))
end))


let split = (fun ( s  :  'a seq ) ( i  :  Prims.nat ) -> (((slice s (Prims.parse_int "0") i)), ((slice s i (length s)))))


let append = (fun ( s1  :  'a seq ) ( s2  :  'a seq ) -> Seq (Append (s1, s2), (Prims.parse_int "0"), ((length s1) + (length s2))))


type equal =
unit


let eq = (fun ( s1  :  'a seq ) ( s2  :  'a seq ) -> (failwith "Not yet implemented: ArrayRealized.eq"))




