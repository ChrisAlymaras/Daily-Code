import { useState } from 'react';


export default function RandomColor(){
    const [typeOfColor,setTypeOfColor] = useState('HEX');
    const [color,setColor] = useState('#000000');

    function randomColorUtility(length){
        return Math.floor(Math.random() * length);
    }

    function handleCreateRandomHexColor(){
        //#123456
        const hex = [1,2,3,4,5,6,7,8,9,"A","B","C","D","E","F"];
        let hexColor = "#";
        for (let i =0; i<6; i++){
            //return random value from hex array
            hexColor += hex[randomColorUtility(hex.length)];
        }
        console.log(hexColor);
        setColor(hexColor);
    }

    function handleCreateRandomRgbColor(){

        const r = randomColorUtility(256);
        const g = randomColorUtility(256);
        const b = randomColorUtility(256);

        setColor(`rgb(${r},${g},${b})`);
    }

    return (
        <div className="container"
             style={{
                width: "100vw",
                height: "100vh",
                background: color
            }}
        >
            <button onClick={()=>setTypeOfColor('HEX')}>Create HEX Color</button>
            <button onClick={()=>setTypeOfColor('RGB')}>Create RGB Color</button>
            <button onClick={typeOfColor === 'HEX'
                ? handleCreateRandomHexColor
                : handleCreateRandomRgbColor}>
                Generate Random Color
            </button>
            <div style={{
                display: "flex",
                flexDirection: "column",
                justifyContent: "center",
                alignItems: "center",
                fontSize: "30px",
                marginTop: "50px",
                gap: "20px"
            }}>
                <h2>{typeOfColor === 'RGB' ? "RGB Color" : "HEX Color"}</h2>
                <h3>{color}</h3>
            </div>
        </div>
    );
}