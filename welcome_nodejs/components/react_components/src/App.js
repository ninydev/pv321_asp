import './App.css';
import Header from "./layOut/Header";
import Footer from "./layOut/Footer";
import InputReactiveComponent from "./components/InputReactiveComponent";
import VendorsViewLayout from "./components/vendorsView/VendorsViewLayout";

function App() {
  return (
    <div className="App">
      <Header />
        Main Content
        <hr />
        <VendorsViewLayout></VendorsViewLayout>
      <Footer />
    </div>
  );
}

export default App;
