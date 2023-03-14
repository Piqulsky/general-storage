import { useRef, useState } from "react";

function TablePanel({data}) {
    const tbody = useRef();
    const [selected, setSelected] = useState();

    const genTable = () => {
        return data.map((x, index) => {
            return (
                <tr onClick={(event) => {
                        [...tbody.current.children].forEach(x => {
                            x.style.backgroundColor = "white";
                        });
                        event.target.parentElement.style.backgroundColor = "blue";
                        setSelected(event.target.parentElement);
                    }}>
                    <td>{index+1}</td>
                    <td>{x[0]}</td>
                    <td>{x[1]}</td>
                    <td>{x[2]}</td>
                </tr>
            )
        })
    }
    const genInteract = () => {
        if(selected == undefined){
            return;
        }
        return (
            <div>
                <span>Call</span>
                <span>Delete</span>
            </div>
        )
    }

    return (
      <div className="TablePanel">
        <div className="InteractBox">
            {genInteract()}
        </div>
        <div className="TableBox">
            <table>
                <tbody ref={tbody}>
                    <tr>
                        <td>Lp.</td>
                        <td>Name</td>
                        <td>Surname</td>
                        <td>Phone Number</td>
                    </tr>
                    {genTable()}
                </tbody>
            </table>
        </div>
      </div>
    );
  }
  
  export default TablePanel;