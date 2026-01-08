//single selection accordion
//multiple selection
import {useState} from "react";
import data from "./data";
import './styles.css';

export default function Accordion(){
    const [selected,setSelected]=useState(null);
    const [enableMultiSelection,setEnableMultiSelection]=useState(false);
    const [multiple,setMultiple] = useState([]);

    function handleSingleSelection(getCurrentId){
        setSelected(getCurrentId === selected ? null : getCurrentId);
    }

    function handleMultiSelection(getCurrentId){
        let copyMultiple = [...multiple];
        const findIndexOfCurrentId = copyMultiple.indexOf(getCurrentId);

        console.log(findIndexOfCurrentId);
        if(findIndexOfCurrentId === -1){
            copyMultiple.push(getCurrentId);
        }else{
            copyMultiple.splice(findIndexOfCurrentId, 1);
        }
        setMultiple(copyMultiple);
    }

    return (<div className="wrapper">
        <button onClick={()=>setEnableMultiSelection(!enableMultiSelection)}>
            Enable Multi Selection
        </button>
        <div className="Accordion">
            {
                data && data.length>0 ?
                    data.map(dataItem=>
                        <div className="item">
                            <div className="title" onClick={
                                enableMultiSelection
                                    ? ()=>handleMultiSelection(dataItem.id)
                                    : ()=>handleSingleSelection(dataItem.id)
                            }>
                                <h3>{dataItem.title}</h3>
                                <span>+</span>
                            </div>

                            {enableMultiSelection
                                    ? multiple.indexOf(dataItem.id) !== -1 &&(
                                        <div className="content">{dataItem.content}</div>)
                                    : selected === dataItem.id &&(
                                        <div className="content">{dataItem.content}</div>)
                            }
                        </div>)
                    : <div>No Data Found</div>
            }
        </div>
    </div>)
}
