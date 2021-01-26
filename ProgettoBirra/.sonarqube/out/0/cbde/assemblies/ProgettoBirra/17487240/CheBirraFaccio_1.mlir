func @_ProgettoBirra.CheBirraFaccio.getidRicetta$$() -> i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :16 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :18 :19) // Not a variable of known type: idRicetta
return %0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :18 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.CheBirraFaccio.getquantitaMin$$() -> i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :20 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :22 :19) // Not a variable of known type: quantitaMin
return %0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :22 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.CheBirraFaccio.setidRicetta$int$(i32) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :25 :8) {
^entry (%_idRicetta : i32):
%0 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :25 :33)
cbde.store %_idRicetta, %0 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :25 :33)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :27 :12) // this (ThisExpression)
%2 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :27 :12) // this.idRicetta (SimpleMemberAccessExpression)
%3 = cbde.load %0 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :27 :29)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.CheBirraFaccio.setquantitaMin$int$(i32) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :30 :8) {
^entry (%_quantitaMin : i32):
%0 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :30 :35)
cbde.store %_quantitaMin, %0 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :30 :35)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :32 :12) // this (ThisExpression)
%2 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :32 :12) // this.quantitaMin (SimpleMemberAccessExpression)
%3 = cbde.load %0 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\CheBirraFaccio.cs" :32 :31)
br ^1

^1: // ExitBlock
return

}
