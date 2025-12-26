#light "off"
module LowStar_BufferView_Down

type inverses =
unit

type ('a, 'b) view =
| View of Prims.pos * unit * unit


let uu___is_View = (fun ( projectee  :  ('a, 'b) view ) -> true)


let __proj__View__item__n = (fun ( projectee  :  ('a, 'b) view ) -> (match (projectee) with
| View (n, get, put) -> begin
n
end))

type ('src, 'rrel, 'rel, 'dest) buffer_view =
| BufferView of ('src, 'rrel, 'rel) LowStar_Monotonic_Buffer.mbuffer * ('src, 'dest) view


let uu___is_BufferView = (fun ( projectee  :  ('src, 'rrel, 'rel, 'dest) buffer_view ) -> true)


let __proj__BufferView__item__buf = (fun ( projectee  :  ('src, 'rrel, 'rel, 'dest) buffer_view ) -> (match (projectee) with
| BufferView (buf, v) -> begin
buf
end))


let __proj__BufferView__item__v = (fun ( projectee  :  ('src, 'rrel, 'rel, 'dest) buffer_view ) -> (match (projectee) with
| BufferView (buf, v) -> begin
v
end))


type 'dest buffer =
(unit, unit, unit, (obj, obj, obj, 'dest) buffer_view) FStar_Pervasives.dtuple4


type as_buffer_t =
(obj, obj, obj) LowStar_Monotonic_Buffer.mbuffer


let as_buffer = (fun ( v  :  'b buffer ) -> (

let uu___ = v
in (match (uu___) with
| FStar_Pervasives.Mkdtuple4 (uu___1, uu___2, uu___3, BufferView (b1, uu___4)) -> begin
b1
end)))


let get_view = (fun ( bv  :  'b buffer ) -> (

let uu___ = bv
in (match (uu___) with
| FStar_Pervasives.Mkdtuple4 (uu___1, uu___2, uu___3, BufferView (uu___4, v)) -> begin
v
end)))


type 'h live =
(obj, obj, obj, 'h, obj) LowStar_Monotonic_Buffer.live


type ('h, 'hu) mods =
(obj, 'h, 'hu) LowStar_Monotonic_Buffer.modifies


type ('h, 'hu) modifies =
(obj, 'h, 'hu) LowStar_Monotonic_Buffer.modifies




