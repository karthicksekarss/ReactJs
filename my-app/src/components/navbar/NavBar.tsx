import { Link } from 'react-router-dom';
import "./NavBar.css";

export default function NavBar() {
  return (
    <nav className="navbar-container">
      <Link to="/">
        Home
      </Link>
      <Link to="/about">About</Link>
      <Link to="/contact">Contact</Link>
      <Link to="/student">Student List</Link>
    </nav>
  );
}
