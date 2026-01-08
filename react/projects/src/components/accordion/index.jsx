//single selection accordion
//multiple selection
import {useState} from "react";
import data from "./data";
import './styles.css';

export default function Accordion(){
    const [selected,setSelected]=useState(null);

    function handleSingleSelection(getCurrentId){
        setSelected(getCurrentId === selected ? null : getCurrentId);
    }

    console.log(selected);

    return (<div className="wrapper">
        <div className="Accordion">
            {
                data && data.length>0 ?
                    data.map(dataItem=>
                        <div className="item">
                            <div className="title" onClick={()=>handleSingleSelection(dataItem.id)}>
                                <h3>{dataItem.title}</h3>
                                <span>+</span>
                            </div>

                            {selected === dataItem.id ?
                                <div className="content">{dataItem.content}</div>
                                : null}
                        </div>)
                    : <div>No Data Found</div>
            }
        </div>
    </div>)
}
