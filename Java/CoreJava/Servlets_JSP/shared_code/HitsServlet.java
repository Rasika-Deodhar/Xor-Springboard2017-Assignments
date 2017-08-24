package com.servlet;

import java.io.*;

import javax.servlet.ServletConfig;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

public class HitsServlet extends HttpServlet {
	
	public void doGet(HttpServletRequest request, HttpServletResponse response) 
			throws IOException, ServletException {
		
		HttpSession session = request.getSession(true);
		int hits = 1;
		if (session.isNew()) {
			hits = 1;
		}
		else {
			hits = (Integer)session.getAttribute("HITS");
			hits++;
		}
		session.setAttribute("HITS", hits);
		
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		out.println("<html><body><h1>HITS " + hits + "</h1></body></html>");
		
	}

	public void doPost(HttpServletRequest request, HttpServletResponse response) 
			throws IOException, ServletException {
		doGet(request, response);
	}
}






