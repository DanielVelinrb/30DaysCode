import heapq
import math

graph = {
    'A': {'B': 7, 'C': 3, 'D': 2},
    'B': {'A': 7, 'C': 1, 'E': 2},
    'C': {'A': 3, 'B': 1, 'D': 2, 'E': 2, 'F': 4},
    'D': {'A': 2, 'C': 2, 'F': 3},
    'E': {'B': 2, 'C': 2, 'G': 5},
    'F': {'C': 4, 'D': 3, 'G': 2, 'H': 4},
    'G': {'E': 5, 'F': 2, 'H': 1},
    'H': {'F': 4, 'G': 1}
}


def dijkstra(graph, start):
    distances = {node: math.inf for node in graph}
    distances[start] = 0
    queue = [(0, start)]
    
    while queue:
        current_distance, current_node = heapq.heappop(queue)
        
        if current_distance > distances[current_node]:
            continue
  
        for neighbor, weight in graph[current_node].items():
            distance = current_distance + weight
            
            if distance < distances[neighbor]:
                distances[neighbor] = distance
                heapq.heappush(queue, (distance, neighbor))
    
    return distances

start_node = input("Ingrese el nodo de inicio: ")
end_node = input("Ingrese el nodo final: ")

distances = dijkstra(graph, start_node)
shortest_distance = distances[end_node]

if shortest_distance == math.inf:
    print(f"No hay ruta desde {start_node} hasta {end_node}")
else:
    print(f"La distancia más corta entre {start_node} y {end_node} es: {shortest_distance}")