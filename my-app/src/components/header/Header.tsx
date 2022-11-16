import React from "react";
import "./Header.css";

export default function Header(props : any) {
  return (
    <div className="header">
      <h1>{props.title}</h1>
      <p>{props.subtitle}</p>
    </div>
  );
}
