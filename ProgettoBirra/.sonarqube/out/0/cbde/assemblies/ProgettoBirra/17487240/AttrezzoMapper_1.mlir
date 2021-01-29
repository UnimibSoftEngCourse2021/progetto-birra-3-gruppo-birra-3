func @_ProgettoBirra.AttrezzoMapper.getNome$$() -> none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :19 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :21 :19) // Not a variable of known type: nome
return %0 : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :21 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.AttrezzoMapper.getCapacita$$() -> none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :24 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :26 :19) // Not a variable of known type: capacita
return %0 : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :26 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.AttrezzoMapper.setNome$string$(none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :30 :8) {
^entry (%_nome : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :30 :28)
cbde.store %_nome, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :30 :28)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :32 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :32 :12) // this.nome (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :32 :24) // Not a variable of known type: nome
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.AttrezzoMapper.setCapacita$string$(none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :35 :8) {
^entry (%_capacita : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :35 :32)
cbde.store %_capacita, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :35 :32)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :37 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :37 :12) // this.capacita (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\AttrezzoMapper.cs" :37 :28) // Not a variable of known type: capacita
br ^1

^1: // ExitBlock
return

}
