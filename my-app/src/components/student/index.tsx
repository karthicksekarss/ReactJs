import axios from "axios";
import { useState, useEffect, useMemo } from "react";
import Table from "./table";


export default function Student() {
   
    // data state to store the TV Maze API data. Its initial value is an empty array
  const [data, setData] = useState([]);

  // Using useEffect to call the API once mounted and set the data
  // Similar to componentDidMount and componentDidUpdate:
  useEffect(() => {
    (async () => {
      await axios("https://localhost:7248/Student").then(responce =>
      {
        setData(responce.data);
      }).catch();
     
    })();
  }, []);
   
   /* 
    - Columns is a simple array right now, but it will contain some logic later on. It is recommended by react-table to memoize the columns data
    - Here in this example, we have grouped our columns into two headers. react-table is flexible enough to create grouped table headers
  */
  const columns = useMemo(
    () => [
      {
        // first group - TV Show
        Header: "Student List",
        // First group columns
        columns: [
          {
            Header: "Id",
            accessor: "id"
          },
          {
            Header: "Student Id",
            accessor: "studentId"
          },
          {
            Header: "Student Name",
            accessor: "studentName"
          },
          {
            Header: "Date Of Joining",
            accessor: "dateOfJoining"
          },
          {
            Header: "Action"
          }
        ]
      }
    ],
    []
  );

  return (
    <div className="App">
      <Table columns={columns} data={data} />
    </div>
  );
  }