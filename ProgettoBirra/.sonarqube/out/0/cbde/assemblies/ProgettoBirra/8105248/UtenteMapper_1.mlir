func @_ProgettoBirra.UtenteMapper.getEmail$$() -> none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :18 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :19 :19) // Not a variable of known type: email
return %0 : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :19 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.UtenteMapper.getPassword$$() -> none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :22 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :24 :19) // Not a variable of known type: password
return %0 : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :24 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.UtenteMapper.setEmail$string$(none) -> () loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :28 :8) {
^entry (%_email : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :28 :29)
cbde.store %_email, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :28 :29)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :29 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :29 :12) // this.email (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :29 :25) // Not a variable of known type: email
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.UtenteMapper.setPassword$string$(none) -> () loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :32 :8) {
^entry (%_password : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :32 :32)
cbde.store %_password, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :32 :32)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :34 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :34 :12) // this.password (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\UtenteMapper.cs" :34 :28) // Not a variable of known type: password
br ^1

^1: // ExitBlock
return

}
