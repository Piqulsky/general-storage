import { Button } from "react-bootstrap";
import { useRef } from "react";

function FormPanel({data, setData}) {
    const name = useRef();
    const surname = useRef();
    const prefix = useRef();
    const phone = useRef();

    const addData = () => {
        try{
            parseInt(phone.current.value)
        } catch(e) {return;};
        if(prefix.current.value == "----") return;
        else if(prefix.current.value == "+48" && phone.current.value.length != 9) return;
        else if(prefix.current.value == "+49" && !(phone.current.value.length == 10 || phone.current.value.length == 11)) return;
        else if(prefix.current.value == "+1" && phone.current.value.length != 10) return;
        else if(name.current.value[0] != name.current.value[0].toUpperCase() || surname.current.value[0] != surname.current.value[0].toUpperCase()) return;
        else if(name.current.value[0] == name.current.value[0].toUpperCase() && surname.current.value[0] == surname.current.value[0].toUpperCase()){
            let flag = true;
            name.current.value.split('').forEach((x, index) => {
                if(index == 0) return;
                if(x != x.toLowerCase()) flag = false;
            })
            surname.current.value.split('').forEach((x, index) => {
                if(index == 0) return;
                if(x != x.toLowerCase()) flag = false;
            })
            if(!flag) return;
        }
        setData([...data, [name.current.value, surname.current.value, phone.current.value]])
    }

    return (
      <div className="FormPanel">
        <input ref={name} placeholder="Input your name..." /><br />
        <input ref={surname} placeholder="Input your surname..." /><br />
        <select ref={prefix}>
            <option>----</option>
            <option>+48</option>
            <option>+49</option>
            <option>+1</option>
        </select>
        <input ref={phone} placeholder="Input your phone number..." /><br />
        <Button variant="primary" onClick={addData}>Submit</Button>
      </div>
    );
  }
  
  export default FormPanel;