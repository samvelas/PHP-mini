//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from php.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


    using System;
    using System.Text;
    using System.Collections.Generic;

using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class phpLexer : Lexer {
	public const int
		PLUS=1, MINUS=2, MULT=3, DIV=4, EQ=5, ISEQ=6, NOTEQ=7, GT=8, GE=9, LT=10, 
		LE=11, IF=12, ELSEIF=13, ELSEIFDEFAULT=14, ELSE=15, ENDIF=16, ECHO=17, 
		SWITCH=18, ENDSWITCH=19, CASE=20, BREAK=21, DEFAULT=22, VARDUMP=23, FUNCTION=24, 
		RETURN=25, TRUE=26, FALSE=27, LPAREN=28, RPAREN=29, LCURLY=30, RCURLY=31, 
		SEMI=32, COMMA=33, COLON=34, VAR=35, LABEL=36, INTEGER=37, BOOLVAL=38, 
		WS=39;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"PLUS", "MINUS", "MULT", "DIV", "EQ", "ISEQ", "NOTEQ", "GT", "GE", "LT", 
		"LE", "IF", "ELSEIF", "ELSEIFDEFAULT", "ELSE", "ENDIF", "ECHO", "SWITCH", 
		"ENDSWITCH", "CASE", "BREAK", "DEFAULT", "VARDUMP", "FUNCTION", "RETURN", 
		"TRUE", "FALSE", "LPAREN", "RPAREN", "LCURLY", "RCURLY", "SEMI", "COMMA", 
		"COLON", "DOLLAR", "VAR", "LABEL", "LETTER", "DIGIT", "INTEGER", "BOOLVAL", 
		"WS"
	};


	    public void print(string s){
	        Console.Write(s);
	    }

	    public void print(int s){
	            Console.Write(s);
	    }

	    public class Variable{
	        public string name;
	        public string type;
	        public string value;
	    }

	    public class Function{
	        public string name;
	        public int parameterCount;
	        public string returnType;
	        public List<Variable> parameterNames = new List<Variable>();
	        public List<string> arguments = new List<string>();
	    }

	    public string doAction(string oper1, string op, string oper2){

	        long op1 = 0;
	        long op2 = 0;
	        bool bop1 = false;
	        bool bop2 = false;
	        long res = 0;
	        bool boolRes = false;
	        bool isin = false;

	        if(long.TryParse(oper1, out op1) && long.TryParse(oper2, out op2)){
	            switch(op){
	                case "+":
	                res = op1 + op2;
	                isin = true;
	                break;
	                case "-":
	                res = op1 - op2;
	                isin = true;
	                break;
	                case "*":
	                res = op1 * op2;
	                isin = true;
	                break;
	                case "/":
	                res = op1 / op2;
	                isin = true;
	                break;
	                case ">":
	                boolRes = (op1 > op2);
	                break;
	                case "<":
	                boolRes = (op1 < op2);
	                break;
	                case "==":
	                boolRes = (op1 == op2);
	                break;
	                case "!=":
	                boolRes = (op1 != op2);
	                break;
	                case "<=":
	                boolRes = (op1 <= op2);
	                break;
	                case ">=":
	                boolRes = (op1 >= op2);
	                break;
	            }
	        }
	        else if(bool.TryParse(oper1, out bop1) && bool.TryParse(oper2, out bop2)){
	            int op1int = bop1 ? 1 : 0;
	            int op2int = bop2 ? 1 : 0;
	            switch(op){
	                case "+":
	                res = op1int + op2int;
	                isin = true;
	                break;
	                case "-":
	                res = op1int - op2int;
	                isin = true;
	                break;
	                case "*":
	                res = op1int * op2int;
	                isin = true;
	                break;
	                case "/":
	                res = op1int / op2int;
	                isin = true;
	                break;
	                case ">":
	                boolRes = (op1int > op2int);
	                break;
	                case "<":
	                boolRes = (op1int < op2int);
	                break;
	                case "==":
	                boolRes = (op1int == op2int);
	                break;
	                case "!=":
	                boolRes = (op1int != op2int);
	                break;
	                case "<=":
	                boolRes = (op1int <= op2int);
	                break;
	                case ">=":
	                boolRes = (op1int >= op2int);
	                break;
	            }

	        }
	        if(isin){
	            return res.ToString();
	        }
	        else{
	            return boolRes.ToString().ToLower();
	        }
	    }

	    int parCount = 0;
	    int argCount = 0;
	    bool isEnteredElif = false;
	    bool switchBreaked = false;

	    public static List<Variable> vars = new List<Variable>();
	    public static List<Function> functions = new List<Function>();

	    public static List<string> functionParams = new List<string>();
	    public static List<string> functionArgs = new List<string>();

	    



	public phpLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'+'", "'-'", "'*'", "'/'", "'='", "'=='", "'!='", "'>'", "'>='", 
		"'<'", "'<='", "'if'", "'elseif'", "'else if'", "'else'", "'endif'", "'echo'", 
		"'switch'", "'endswitch'", "'case'", "'break'", "'default'", "'var_dump'", 
		"'function'", "'return'", "'true'", "'false'", "'('", "')'", "'{'", "'}'", 
		"';'", "','", "':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PLUS", "MINUS", "MULT", "DIV", "EQ", "ISEQ", "NOTEQ", "GT", "GE", 
		"LT", "LE", "IF", "ELSEIF", "ELSEIFDEFAULT", "ELSE", "ENDIF", "ECHO", 
		"SWITCH", "ENDSWITCH", "CASE", "BREAK", "DEFAULT", "VARDUMP", "FUNCTION", 
		"RETURN", "TRUE", "FALSE", "LPAREN", "RPAREN", "LCURLY", "RCURLY", "SEMI", 
		"COMMA", "COLON", "VAR", "LABEL", "INTEGER", "BOOLVAL", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "php.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2)\x10E");
		sb.Append("\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6");
		sb.Append("\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r");
		sb.Append("\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4\x12");
		sb.Append("\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16\x4");
		sb.Append("\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B\t\x1B");
		sb.Append("\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t ");
		sb.Append("\x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t");
		sb.Append("(\x4)\t)\x4*\t*\x4+\t+\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3");
		sb.Append("\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\t\x3");
		sb.Append("\t\x3\n\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3");
		sb.Append("\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3");
		sb.Append("\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10");
		sb.Append("\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3");
		sb.Append("\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13");
		sb.Append("\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3");
		sb.Append("\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x16");
		sb.Append("\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3");
		sb.Append("\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18");
		sb.Append("\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3");
		sb.Append("\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A");
		sb.Append("\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3");
		sb.Append("\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D");
		sb.Append("\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3\"\x3\"\x3#\x3");
		sb.Append("#\x3$\x3$\x3%\x3%\x3%\a%\xEF\n%\f%\xE%\xF2\v%\x3&\x3&\a&\xF6");
		sb.Append("\n&\f&\xE&\xF9\v&\x3\'\x3\'\x3(\x3(\x3)\x6)\x100\n)\r)\xE)\x101");
		sb.Append("\x3*\x3*\x5*\x106\n*\x3+\x6+\x109\n+\r+\xE+\x10A\x3+\x3+\x2");
		sb.Append("\x2,\x3\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17");
		sb.Append("\r\x19\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+");
		sb.Append("\x17-\x18/\x19\x31\x1A\x33\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F");
		sb.Append("= ?!\x41\"\x43#\x45$G\x2I%K&M\x2O\x2Q\'S(U)\x3\x2\x6\x5\x2\x43");
		sb.Append("\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x4\x2\x43\\\x63");
		sb.Append("|\x5\x2\v\f\xF\xF\"\"\x10F\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2");
		sb.Append("\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r");
		sb.Append("\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3");
		sb.Append("\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2");
		sb.Append("\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2");
		sb.Append("\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3");
		sb.Append("\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2");
		sb.Append("/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3");
		sb.Append("\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2");
		sb.Append("\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43");
		sb.Append("\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2");
		sb.Append("\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x3W\x3\x2");
		sb.Append("\x2\x2\x5Y\x3\x2\x2\x2\a[\x3\x2\x2\x2\t]\x3\x2\x2\x2\v_\x3\x2");
		sb.Append("\x2\x2\r\x61\x3\x2\x2\x2\xF\x64\x3\x2\x2\x2\x11g\x3\x2\x2\x2");
		sb.Append("\x13i\x3\x2\x2\x2\x15l\x3\x2\x2\x2\x17n\x3\x2\x2\x2\x19q\x3");
		sb.Append("\x2\x2\x2\x1Bt\x3\x2\x2\x2\x1D{\x3\x2\x2\x2\x1F\x83\x3\x2\x2");
		sb.Append("\x2!\x88\x3\x2\x2\x2#\x8E\x3\x2\x2\x2%\x93\x3\x2\x2\x2\'\x9A");
		sb.Append("\x3\x2\x2\x2)\xA4\x3\x2\x2\x2+\xA9\x3\x2\x2\x2-\xAF\x3\x2\x2");
		sb.Append("\x2/\xB7\x3\x2\x2\x2\x31\xC0\x3\x2\x2\x2\x33\xC9\x3\x2\x2\x2");
		sb.Append("\x35\xD0\x3\x2\x2\x2\x37\xD5\x3\x2\x2\x2\x39\xDB\x3\x2\x2\x2");
		sb.Append(";\xDD\x3\x2\x2\x2=\xDF\x3\x2\x2\x2?\xE1\x3\x2\x2\x2\x41\xE3");
		sb.Append("\x3\x2\x2\x2\x43\xE5\x3\x2\x2\x2\x45\xE7\x3\x2\x2\x2G\xE9\x3");
		sb.Append("\x2\x2\x2I\xEB\x3\x2\x2\x2K\xF3\x3\x2\x2\x2M\xFA\x3\x2\x2\x2");
		sb.Append("O\xFC\x3\x2\x2\x2Q\xFF\x3\x2\x2\x2S\x105\x3\x2\x2\x2U\x108\x3");
		sb.Append("\x2\x2\x2WX\a-\x2\x2X\x4\x3\x2\x2\x2YZ\a/\x2\x2Z\x6\x3\x2\x2");
		sb.Append("\x2[\\\a,\x2\x2\\\b\x3\x2\x2\x2]^\a\x31\x2\x2^\n\x3\x2\x2\x2");
		sb.Append("_`\a?\x2\x2`\f\x3\x2\x2\x2\x61\x62\a?\x2\x2\x62\x63\a?\x2\x2");
		sb.Append("\x63\xE\x3\x2\x2\x2\x64\x65\a#\x2\x2\x65\x66\a?\x2\x2\x66\x10");
		sb.Append("\x3\x2\x2\x2gh\a@\x2\x2h\x12\x3\x2\x2\x2ij\a@\x2\x2jk\a?\x2");
		sb.Append("\x2k\x14\x3\x2\x2\x2lm\a>\x2\x2m\x16\x3\x2\x2\x2no\a>\x2\x2");
		sb.Append("op\a?\x2\x2p\x18\x3\x2\x2\x2qr\ak\x2\x2rs\ah\x2\x2s\x1A\x3\x2");
		sb.Append("\x2\x2tu\ag\x2\x2uv\an\x2\x2vw\au\x2\x2wx\ag\x2\x2xy\ak\x2\x2");
		sb.Append("yz\ah\x2\x2z\x1C\x3\x2\x2\x2{|\ag\x2\x2|}\an\x2\x2}~\au\x2\x2");
		sb.Append("~\x7F\ag\x2\x2\x7F\x80\a\"\x2\x2\x80\x81\ak\x2\x2\x81\x82\a");
		sb.Append("h\x2\x2\x82\x1E\x3\x2\x2\x2\x83\x84\ag\x2\x2\x84\x85\an\x2\x2");
		sb.Append("\x85\x86\au\x2\x2\x86\x87\ag\x2\x2\x87 \x3\x2\x2\x2\x88\x89");
		sb.Append("\ag\x2\x2\x89\x8A\ap\x2\x2\x8A\x8B\a\x66\x2\x2\x8B\x8C\ak\x2");
		sb.Append("\x2\x8C\x8D\ah\x2\x2\x8D\"\x3\x2\x2\x2\x8E\x8F\ag\x2\x2\x8F");
		sb.Append("\x90\a\x65\x2\x2\x90\x91\aj\x2\x2\x91\x92\aq\x2\x2\x92$\x3\x2");
		sb.Append("\x2\x2\x93\x94\au\x2\x2\x94\x95\ay\x2\x2\x95\x96\ak\x2\x2\x96");
		sb.Append("\x97\av\x2\x2\x97\x98\a\x65\x2\x2\x98\x99\aj\x2\x2\x99&\x3\x2");
		sb.Append("\x2\x2\x9A\x9B\ag\x2\x2\x9B\x9C\ap\x2\x2\x9C\x9D\a\x66\x2\x2");
		sb.Append("\x9D\x9E\au\x2\x2\x9E\x9F\ay\x2\x2\x9F\xA0\ak\x2\x2\xA0\xA1");
		sb.Append("\av\x2\x2\xA1\xA2\a\x65\x2\x2\xA2\xA3\aj\x2\x2\xA3(\x3\x2\x2");
		sb.Append("\x2\xA4\xA5\a\x65\x2\x2\xA5\xA6\a\x63\x2\x2\xA6\xA7\au\x2\x2");
		sb.Append("\xA7\xA8\ag\x2\x2\xA8*\x3\x2\x2\x2\xA9\xAA\a\x64\x2\x2\xAA\xAB");
		sb.Append("\at\x2\x2\xAB\xAC\ag\x2\x2\xAC\xAD\a\x63\x2\x2\xAD\xAE\am\x2");
		sb.Append("\x2\xAE,\x3\x2\x2\x2\xAF\xB0\a\x66\x2\x2\xB0\xB1\ag\x2\x2\xB1");
		sb.Append("\xB2\ah\x2\x2\xB2\xB3\a\x63\x2\x2\xB3\xB4\aw\x2\x2\xB4\xB5\a");
		sb.Append("n\x2\x2\xB5\xB6\av\x2\x2\xB6.\x3\x2\x2\x2\xB7\xB8\ax\x2\x2\xB8");
		sb.Append("\xB9\a\x63\x2\x2\xB9\xBA\at\x2\x2\xBA\xBB\a\x61\x2\x2\xBB\xBC");
		sb.Append("\a\x66\x2\x2\xBC\xBD\aw\x2\x2\xBD\xBE\ao\x2\x2\xBE\xBF\ar\x2");
		sb.Append("\x2\xBF\x30\x3\x2\x2\x2\xC0\xC1\ah\x2\x2\xC1\xC2\aw\x2\x2\xC2");
		sb.Append("\xC3\ap\x2\x2\xC3\xC4\a\x65\x2\x2\xC4\xC5\av\x2\x2\xC5\xC6\a");
		sb.Append("k\x2\x2\xC6\xC7\aq\x2\x2\xC7\xC8\ap\x2\x2\xC8\x32\x3\x2\x2\x2");
		sb.Append("\xC9\xCA\at\x2\x2\xCA\xCB\ag\x2\x2\xCB\xCC\av\x2\x2\xCC\xCD");
		sb.Append("\aw\x2\x2\xCD\xCE\at\x2\x2\xCE\xCF\ap\x2\x2\xCF\x34\x3\x2\x2");
		sb.Append("\x2\xD0\xD1\av\x2\x2\xD1\xD2\at\x2\x2\xD2\xD3\aw\x2\x2\xD3\xD4");
		sb.Append("\ag\x2\x2\xD4\x36\x3\x2\x2\x2\xD5\xD6\ah\x2\x2\xD6\xD7\a\x63");
		sb.Append("\x2\x2\xD7\xD8\an\x2\x2\xD8\xD9\au\x2\x2\xD9\xDA\ag\x2\x2\xDA");
		sb.Append("\x38\x3\x2\x2\x2\xDB\xDC\a*\x2\x2\xDC:\x3\x2\x2\x2\xDD\xDE\a");
		sb.Append("+\x2\x2\xDE<\x3\x2\x2\x2\xDF\xE0\a}\x2\x2\xE0>\x3\x2\x2\x2\xE1");
		sb.Append("\xE2\a\x7F\x2\x2\xE2@\x3\x2\x2\x2\xE3\xE4\a=\x2\x2\xE4\x42\x3");
		sb.Append("\x2\x2\x2\xE5\xE6\a.\x2\x2\xE6\x44\x3\x2\x2\x2\xE7\xE8\a<\x2");
		sb.Append("\x2\xE8\x46\x3\x2\x2\x2\xE9\xEA\a&\x2\x2\xEAH\x3\x2\x2\x2\xEB");
		sb.Append("\xEC\x5G$\x2\xEC\xF0\t\x2\x2\x2\xED\xEF\t\x3\x2\x2\xEE\xED\x3");
		sb.Append("\x2\x2\x2\xEF\xF2\x3\x2\x2\x2\xF0\xEE\x3\x2\x2\x2\xF0\xF1\x3");
		sb.Append("\x2\x2\x2\xF1J\x3\x2\x2\x2\xF2\xF0\x3\x2\x2\x2\xF3\xF7\t\x2");
		sb.Append("\x2\x2\xF4\xF6\t\x3\x2\x2\xF5\xF4\x3\x2\x2\x2\xF6\xF9\x3\x2");
		sb.Append("\x2\x2\xF7\xF5\x3\x2\x2\x2\xF7\xF8\x3\x2\x2\x2\xF8L\x3\x2\x2");
		sb.Append("\x2\xF9\xF7\x3\x2\x2\x2\xFA\xFB\t\x4\x2\x2\xFBN\x3\x2\x2\x2");
		sb.Append("\xFC\xFD\x4\x32;\x2\xFDP\x3\x2\x2\x2\xFE\x100\x5O(\x2\xFF\xFE");
		sb.Append("\x3\x2\x2\x2\x100\x101\x3\x2\x2\x2\x101\xFF\x3\x2\x2\x2\x101");
		sb.Append("\x102\x3\x2\x2\x2\x102R\x3\x2\x2\x2\x103\x106\x5\x35\x1B\x2");
		sb.Append("\x104\x106\x5\x37\x1C\x2\x105\x103\x3\x2\x2\x2\x105\x104\x3");
		sb.Append("\x2\x2\x2\x106T\x3\x2\x2\x2\x107\x109\t\x5\x2\x2\x108\x107\x3");
		sb.Append("\x2\x2\x2\x109\x10A\x3\x2\x2\x2\x10A\x108\x3\x2\x2\x2\x10A\x10B");
		sb.Append("\x3\x2\x2\x2\x10B\x10C\x3\x2\x2\x2\x10C\x10D\b+\x2\x2\x10DV");
		sb.Append("\x3\x2\x2\x2\b\x2\xF0\xF7\x101\x105\x10A\x3\b\x2\x2");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
