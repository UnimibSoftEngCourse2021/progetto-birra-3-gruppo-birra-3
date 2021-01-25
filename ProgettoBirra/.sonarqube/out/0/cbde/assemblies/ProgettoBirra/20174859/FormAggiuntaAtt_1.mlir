func @_ProgettoBirra.FormAggiuntaAtt.buttonCreaAtt_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :21 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :21 :41)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :21 :41)
%1 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :21 :56)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :21 :56)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :23 :12) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :23 :31) // Globals.emailGlobal (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :23 :52) // Not a variable of known type: textBoxNomeAtt
%5 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :23 :52) // textBoxNomeAtt.Text (SimpleMemberAccessExpression)
// Entity from another assembly: Convert
%6 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :23 :89) // this (ThisExpression)
%7 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :23 :89) // this.textBoxCapacita (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :23 :89) // this.textBoxCapacita.Text (SimpleMemberAccessExpression)
%9 = cbde.unknown : i32 loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :23 :73) // Convert.ToInt32(this.textBoxCapacita.Text) (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :23 :12) // database.InsertAtt(Globals.emailGlobal, textBoxNomeAtt.Text, Convert.ToInt32(this.textBoxCapacita.Text)) (InvocationExpression)
%11 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :25 :47) // new FormGestioneAttrezzatura() (ObjectCreationExpression)
%13 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :26 :12) // this (ThisExpression)
%14 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :26 :12) // this.Hide() (InvocationExpression)
%15 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :27 :12) // this (ThisExpression)
%16 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :27 :12) // this.Close() (InvocationExpression)
%17 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :28 :12) // Not a variable of known type: newform
%18 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :28 :12) // newform.ShowDialog() (InvocationExpression)
%19 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :29 :12) // this (ThisExpression)
%20 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiuntaAtt.cs" :29 :12) // this.Show() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
