import Accordion from './components/accordion/index.jsx';
import RandomColor from './components/color-generator/index.jsx';
import './App.css';

function App() {
  return (
    <div className="App">
        {/*accordion component*/}
        <Accordion/>
        {/*Random Color component*/}
        <RandomColor/>
    </div>
  );
}

export default App;
