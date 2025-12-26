#light "off"
module LowStar_BufferView

type inverses =
unit

type ('a, 'b) view =
| View of Prims.pos * unit * unit


let uu___is_View = (fun ( projectee  :  ('a, 'b) view ) -> true)


let __proj__View__item__n = (fun ( projectee  :  ('a, 'b) view ) -> (match (projectee) with
| View (n, get, put) -> begin
n
end))

type ('a, 'rrel, 'rel, 'b) buffer_view =
| BufferView of ('a, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer * ('a, 'b) view


let uu___is_BufferView = (fun ( projectee  :  ('a, 'rrel, 'rel, 'b) buffer_view ) -> true)


let __proj__BufferView__item__buf = (fun ( projectee  :  ('a, 'rrel, 'rel, 'b) buffer_view ) -> (match (projectee) with
| BufferView (buf, v) -> begin
buf
end))


let __proj__BufferView__item__v = (fun ( projectee  :  ('a, 'rrel, 'rel, 'b) buffer_view ) -> (match (projectee) with
| BufferView (buf, v) -> begin
v
end))


type 'dest buffer =
(unit, unit, unit, (obj, obj, obj, 'dest) buffer_view) FStar_Pervasives.dtuple4


type as_buffer_t =
(obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer


let as_buffer = (fun ( v  :  'b buffer ) -> (__proj__BufferView__item__buf (FStar_Pervasives.__proj__Mkdtuple4__item___4 v)))


let get_view = (fun ( v  :  'b buffer ) -> (__proj__BufferView__item__v (FStar_Pervasives.__proj__Mkdtuple4__item___4 v)))


type 'h live =
(obj, obj, obj, 'h, obj) LowStar_Monotonic_Buffer.live


type ('h, 'hu) modifies =
(obj, 'h, 'hu) LowStar_Monotonic_Buffer.modifies




