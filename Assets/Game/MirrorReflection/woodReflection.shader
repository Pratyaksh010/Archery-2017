Shader "FX/Wood Reflection" { 
Properties {
     _Color1 ("Main color", Color) = (1,1,1,1)
      _Color2 ("Reflection color", Color) = (1,1,1,1)
    _MainTex ("Base (RGB)", 2D) = "white" {}
    _ReflectionTex ("Reflection", 2D) = "black" { TexGen ObjectLinear }
    _testTex ("Test", 2D) = "black" {  }
   
     //_arrow ("arrow", 2D) = "white" { TexGen ObjectLinear }
}

// two texture cards: full thing
Subshader { 
      //Tags {Queue = Transparent}
    //ZWrite Off
   // Blend SrcAlpha OneMinusSrcAlpha
     Pass {
      		//SetTexture[_MainTex] { combine texture }
       		
      		
      		SetTexture[_ReflectionTex]{
      		ConstantColor [_Color2]Combine texture*constant}
      		SetTexture[_ReflectionTex] { matrix [_ProjMatrix] combine texture +  previous }
      		
      		SetTexture[_testTex] { combine texture *  previous }
      		SetTexture[_MainTex] {
            combine texture +  previous}
      		}
	
	}

//fallback: just main texture
Subshader {
    Pass {
        SetTexture [_MainTex] { combine texture }
    }
}

}
