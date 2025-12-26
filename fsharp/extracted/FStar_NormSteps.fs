#light "off"
module FStar_NormSteps
type norm_step =
| Simpl
| Weak
| HNF
| Primops
| Delta
| Zeta
| ZetaFull
| Iota
| NBE
| Reify
| NormDebug
| UnfoldOnly of Prims.string Prims.list
| UnfoldOnce of Prims.string Prims.list
| UnfoldFully of Prims.string Prims.list
| UnfoldAttr of Prims.string Prims.list
| UnfoldQual of Prims.string Prims.list
| UnfoldNamespace of Prims.string Prims.list
| Unmeta
| Unascribe


let uu___is_Simpl : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Simpl -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Weak : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Weak -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_HNF : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| HNF -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Primops : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Primops -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Delta : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Delta -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Zeta : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Zeta -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_ZetaFull : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| ZetaFull -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Iota : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Iota -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_NBE : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| NBE -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Reify : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Reify -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_NormDebug : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| NormDebug -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_UnfoldOnly : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldOnly (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__UnfoldOnly__item___0 : norm_step  ->  Prims.string Prims.list = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldOnly (_0) -> begin
_0
end))


let uu___is_UnfoldOnce : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldOnce (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__UnfoldOnce__item___0 : norm_step  ->  Prims.string Prims.list = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldOnce (_0) -> begin
_0
end))


let uu___is_UnfoldFully : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldFully (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__UnfoldFully__item___0 : norm_step  ->  Prims.string Prims.list = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldFully (_0) -> begin
_0
end))


let uu___is_UnfoldAttr : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldAttr (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__UnfoldAttr__item___0 : norm_step  ->  Prims.string Prims.list = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldAttr (_0) -> begin
_0
end))


let uu___is_UnfoldQual : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldQual (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__UnfoldQual__item___0 : norm_step  ->  Prims.string Prims.list = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldQual (_0) -> begin
_0
end))


let uu___is_UnfoldNamespace : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldNamespace (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__UnfoldNamespace__item___0 : norm_step  ->  Prims.string Prims.list = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldNamespace (_0) -> begin
_0
end))


let uu___is_Unmeta : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Unmeta -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Unascribe : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Unascribe -> begin
true
end
| uu___ -> begin
false
end))


let simplify : norm_step = Simpl


let weak : norm_step = Weak


let hnf : norm_step = HNF


let primops : norm_step = Primops


let delta : norm_step = Delta


let norm_debug : norm_step = NormDebug


let zeta : norm_step = Zeta


let zeta_full : norm_step = ZetaFull


let iota : norm_step = Iota


let nbe : norm_step = NBE


let reify_ : norm_step = Reify


let delta_only : Prims.string Prims.list  ->  norm_step = (fun ( s  :  Prims.string Prims.list ) -> UnfoldOnly (s))


let delta_once : Prims.string Prims.list  ->  norm_step = (fun ( s  :  Prims.string Prims.list ) -> UnfoldOnce (s))


let delta_fully : Prims.string Prims.list  ->  norm_step = (fun ( s  :  Prims.string Prims.list ) -> UnfoldFully (s))


let delta_attr : Prims.string Prims.list  ->  norm_step = (fun ( s  :  Prims.string Prims.list ) -> UnfoldAttr (s))


let delta_qualifier : Prims.string Prims.list  ->  norm_step = (fun ( s  :  Prims.string Prims.list ) -> UnfoldQual (s))


let delta_namespace : Prims.string Prims.list  ->  norm_step = (fun ( s  :  Prims.string Prims.list ) -> UnfoldNamespace (s))


let unmeta : norm_step = Unmeta


let unascribe : norm_step = Unascribe




