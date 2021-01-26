func @_ProgettoBirra.FormAggiuntaAtt.buttonCreaAtt_Click$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :14 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :14 :41)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :14 :41)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :14 :56)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :14 :56)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :16 :12) // Not a variable of known type: database
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :16 :31) // Not a variable of known type: textBoxNomeAtt
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :16 :31) // textBoxNomeAtt.Text (SimpleMemberAccessExpression)
// Entity from another assembly: Convert
%5 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :16 :68) // this (ThisExpression)
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :16 :68) // this.textBoxCapacita (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :16 :68) // this.textBoxCapacita.Text (SimpleMemberAccessExpression)
%8 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :16 :52) // Convert.ToInt32(this.textBoxCapacita.Text) (InvocationExpression)
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :16 :12) // database.InsertAtt(textBoxNomeAtt.Text, Convert.ToInt32(this.textBoxCapacita.Text)) (InvocationExpression)
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :19 :12) // this (ThisExpression)
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :19 :12) // this.Close() (InvocationExpression)
%12 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :20 :12) // this (ThisExpression)
%13 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :20 :12) // this.Dispose() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
