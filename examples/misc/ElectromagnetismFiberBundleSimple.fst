module ElectromagnetismFiberBundleSimple

// Simple test types
type spacetime = { x: nat; y: nat; z: nat; t: nat }
type gauge_param = int
type u1_element = { phase: gauge_param }

// Simple test functions
let u1_identity : u1_element = { phase = 0 }

let add_phase (g1 g2: u1_element) = 
  { phase = g1.phase + g2.phase }

let test_spacetime = { x = 1; y = 2; z = 3; t = 0 }